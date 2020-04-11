using Encryptor;
using SQLController;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmPasswordModifier : Form {
        #region Global Variables

        // Create a variable for the Password and User ID
        // Create a variable for the Password DataTable
        // Create a variable for checking for a new password
        long _passwordID = 0, _userID = 0;
        DataTable _passwordTable, _tagTable;
        bool _isNew = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of frmPasswordManager
        /// </summary>
        /// <param name="userID">The user logged in</param>
        public frmPasswordModifier(long userID, Point location) {
            // Initialize the form components
            // Assign true to _isNew
            // Assign the userID to the Global Variable
            // Initialize the form
            InitializeComponent();
            _isNew = true;
            _userID = userID;
            InitializeForm();

            // Set the button text to "Add"
            gbSave.Visible = false;
            gbCreate.Visible = true;

            // Set form location with the location values
            Location = location;
        }

        /// <summary>
        /// Create a new instance of frmPasswordManager
        /// </summary>
        /// <param name="passwordID">The password to edit</param>
        /// <param name="userID">The user logged in</param>
        public frmPasswordModifier(long passwordID, long userID, Point location) {
            // Initialize the form components
            // Assign the passwordID to the Global Variable
            // Assign the userID to the Global Variable
            // Initialize the form
            InitializeComponent();
            _passwordID = passwordID;
            _userID = userID;
            InitializeForm();

            // Change the button text to "Save"
            gbSave.Visible = true;
            gbCreate.Visible = false;

            // Set form location with the location values
            Location = location;
        }

        /// <summary>
        /// Initializes the form
        /// </summary>
        private void InitializeForm() {
            // Initialize the DataTable
            // Initialize the Tag DataTable
            // Bind data to the form components
            InitializeDatatable();
            InitializeTagTable();
            BindControls();
        }

        #endregion

        #region Button Events

        private void BtnCreate_Click(object sender, EventArgs e) {
            saveChanges();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            saveChanges();
        }

        #endregion

        #region TextBox Events

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e) {
            // Check if the user pressed Enter
            if (e.KeyCode == Keys.Enter) {
                // Save changes
                // Set the DialogResult to OK
                saveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            // Check if the user pressed Enter
            if (e.KeyChar == (char)13) {
                // Set the key handled to true
                e.Handled = true;
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initializes the Password DataTable
        /// </summary>
        private void InitializeDatatable() {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE PasswordID={_passwordID}";
            _passwordTable = Context.GetDataTable(sqlQuery, "Passwords");

            // Check if _isNew is true
            // Else decrypt the password
            if (_isNew) {
                // Create and assign a new DataRow
                // Assign an empty row to the Passwords DataTable
                DataRow row = _passwordTable.NewRow();
                _passwordTable.Rows.Add(row);
            } else {
                // Create and assign the users username
                // Check if the username exists
                // Update the UserID in the Password DataTable
                string username = getUsername();
                if (string.IsNullOrEmpty(username)) {
                    MessageBox.Show("Couldn't find your username. Please login again.",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    return;
                }

                try {
                    // Create and assign the decrypted password
                    // Check if the password was decrypted properly
                    // Update the PasswordEncrypted in the Password DataTable
                    string passwordDecrypted = Encryption.Decrypt(_passwordTable.Rows[0]["PasswordEncrypted"].ToString(), username);

                    if (string.IsNullOrEmpty(passwordDecrypted)) {
                        MessageBox.Show("Failed to decrypt. Try again later.",
                            Properties.Settings.Default.ProjectName,
                            MessageBoxButtons.OK);
                        return;
                    }
                    _passwordTable.Rows[0]["PasswordEncrypted"] = passwordDecrypted;
                } catch (Exception) {
                    DeletePasswords(_userID);
                    MessageBox.Show("Invalid Decryption Key Provided. Deleted All Passwords.");
                }
            }
        }

        /// <summary>
        /// Initializes the Tag DataTable
        /// </summary>
        private void InitializeTagTable() {
            // Create and assign a new SQL Query
            string sqlQuery = $"SELECT TagID, TagDisplay FROM Tags";

            // Assign the Tag DataTable with the Tag DataTable
            // Create a new column with the TagID and 
            _tagTable = Context.GetDataTable(sqlQuery, "Tags");

            // Adding new column for ComboBox
            _tagTable.Columns.Add("Display", typeof(string), "TagID + ' - ' + TagDisplay");
        }

        /// <summary>
        /// Binds data to the text boxes
        /// </summary>
        private void BindControls() {
            // Bind txtTitle with PasswordTitle
            // Bind txtUsername with PasswordUsername
            // Bind txtPassword with PasswordEncrypted
            txtTitle.DataBindings.Add("Text", _passwordTable, "PasswordTitle");
            txtUsername.DataBindings.Add("Text", _passwordTable, "PasswordUsername");
            txtPassword.DataBindings.Add("Text", _passwordTable, "PasswordEncrypted");

            // Bind the ValueMember with TagID
            // Bind the DisplayMember with the column Display
            // Bind the cboTags with the Tag DataTable
            // Assign the BindingContext with the BindingContext
            cboTags.ValueMember = "TagID";
            cboTags.DisplayMember = "Display";
            cboTags.DataSource = _tagTable;
            cboTags.BindingContext = this.BindingContext;

            // Check if _isNew is true
            // Set the Tag SelectedIndex with -1
            // Else set the Tag SelectedValue to TagID Row
            if (_isNew || _passwordTable.Rows[0]["TagID"] is DBNull) {
                cboTags.SelectedIndex = -1;
            } else {
                cboTags.SelectedValue = _passwordTable.Rows[0]["TagID"];
            }
        }

        /// <summary>
        /// Get the users username
        /// </summary>
        /// <returns>String Username</returns>
        private string getUsername() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT UserID, Username FROM Users " +
                $"WHERE UserID={_userID}";
            DataTable userTable = Context.GetDataTable(sqlQuery, "Users");

            if (userTable.Rows.Count < 1) {
                return null;
            } else {
                return userTable.Rows[0]["Username"].ToString();
            }
        }

        /// <summary>
        /// Saves any changes to the DataTable (including creation)
        /// </summary>
        private void saveChanges() {
            // Checking if the user has inputted values
            // Showing MessageBox providing reason
            if (string.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Please enter a Password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Create and assign the users username
            // Check if the username exists
            // Update the UserID in the Password DataTable
            string username = getUsername();
            if (string.IsNullOrEmpty(username)) {
                MessageBox.Show("Couldn't find your username. Please login again.",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }
            _passwordTable.Rows[0]["UserID"] = _userID;

            // Update the TagID in the Passwords DataTable
            if (cboTags.SelectedIndex == -1) {
                _passwordTable.Rows[0]["TagID"] = DBNull.Value;
            } else {
                _passwordTable.Rows[0]["TagID"] = cboTags.SelectedValue;
            }

            // Create and assign the encrypted password
            // Check if the password was encrypted properly
            // Update the PasswordEncrypted in the Password DataTable
            string passwordEncrypted = Encryption.Encrypt(txtPassword.Text, username);
            if (string.IsNullOrEmpty(passwordEncrypted)) {
                MessageBox.Show("Failed to encrypt. Try again later.",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }
            _passwordTable.Rows[0]["PasswordEncrypted"] = passwordEncrypted;

            // Save the DataTable and Table
            _passwordTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_passwordTable);

            // Close form
            Close();
        }

        /// <summary>
        /// Deletes all the passwords
        /// </summary>
        private void DeletePasswords(long userID) {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE UserID={userID}";
            DataTable passwordTable = Context.GetDataTable(sqlQuery, "Passwords");
            if (passwordTable.Rows.Count > 0) {
                // for each row in the Password DataTable
                foreach (DataRow row in passwordTable.Rows) {
                    // Delete the row
                    // Save the row
                    row.Delete();
                    row.EndEdit();
                }

                // Save Table
                Context.SaveDataBaseTable(passwordTable);
            }
        }

        #endregion
    }
}
