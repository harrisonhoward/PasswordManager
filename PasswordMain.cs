using PasswordEncryptor;
using SQLController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmPasswordMain : Form {
        #region Global Variables

        // Variables for Main Form
        long _userID = 0;
        DataTable _userTable;
        Panel _currentPanel = null;
        ToolStripButton _currentButton = null;

        // Variables for Password List
        DataView _dvPassword;
        DataTable _passwordTable;

        // Variables for Account Settings
        bool _userAdmin;
        DataTable _passwordsTable;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of PasswordMain
        /// </summary>
        /// <param name="userID">Provided User ID</param> 
        public frmPasswordMain(long userID) {
            // Initialize the form components
            // Assign the User ID with the provided User ID
            // Initialize the form
            InitializeComponent();
            _userID = userID;
            InitializeForm();
        }

        private void InitializeForm() {
            // Initialize the User DataTable
            InitializeUserTable();

            // Create the Account Combobox with Items
            // Set the SelectedIndex to 0
            tsdAccount.Text = $"Account: {_userTable.Rows[0]["Username"]}";
            tsdAccount.Select();

            // Hide every panel
            panPasswordList.Hide();
            panAccountSettings.Hide();
        }

        #endregion

        #region ToolStrip Events

        private void TsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // TOOLSTRIP BUTTON - PASSWORDLIST
            if (e.ClickedItem.Equals(tsbPasswordList)) {
                // Check if there is a current shown panel
                // Hide the panel
                if (_currentPanel != null) {
                    _currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (_currentButton != null) {
                    _currentButton.Checked = false;
                }
                // Set the current panel
                // Set the current button
                _currentPanel = panPasswordList;
                _currentButton = tsbPasswordList;

                // Populate the DataGrid on the Panel
                PopulatePasswordGrid();
            } else if (e.ClickedItem.Equals(tsbAccount)) {
                // Check if there is a current shown panel
                // Hide the panel
                if (_currentPanel != null) {
                    _currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (_currentButton != null) {
                    _currentButton.Checked = false;
                }

                // Set the current panel
                // Set the current button
                _currentPanel = panAccountSettings;
                _currentButton = tsbAccount;

                // Check if the user is an admin
                // Disable save button
                isAdmin();
                btnAccountSave.Enabled = false;
            }
            // Set the current panel to show
            // Set the current button to active
            if (e.ClickedItem.GetType().Equals(typeof(ToolStripButton))) {
                _currentPanel.Show();
                _currentButton.Checked = true;
            }
        }

        #endregion

        #region ToolStripItem Events

        private void TsdAccount_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Checking if they clicked logout
            if (e.ClickedItem.Equals(tsdiLogout)) {
                // Logout
                Logout();
            }
        }

        #endregion

        #region Button Events

        private void BtnExit_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion

        #region Main Helper Methods

        /// <summary>
        /// Run a form
        /// </summary>
        private void ThreadProcLogin() {
            Application.Run(new frmLogin());
        }

        /// <summary>
        /// Start a new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        private void ThreadStart(System.Threading.Thread thread) {
            // Start the thread
            // Close the current form
            thread.Start();
            this.Close();
        }

        /// <summary>
        /// Initializes the User DataTable
        /// </summary>
        private void InitializeUserTable() {
            // Create and assign a new SQL Query
            // Assign the User DataTable with the User Table
            string sqlQuery =
                "SELECT * FROM Users " +
                $"WHERE UserID='{_userID}'";
            _userTable = Context.GetDataTable(sqlQuery, "Users", true);
        }

        /// <summary>
        /// Logs out of the form
        /// </summary>
        private void Logout() {
            // Create and assign LoginDetails DataTable
            DataTable loginTable = Context.GetDataTable("LoginDetails");

            // Check if the DataTable contains rows
            if (loginTable.Rows.Count > 0) {
                // For each row in the DataTable
                foreach (DataRow row in loginTable.Rows) {
                    // Delete the row
                    row.Delete();
                    // End any more editing on that row
                    row.EndEdit();
                }
                // Save the Table
                Context.SaveDataBaseTable(loginTable);
            }
            // Set stay signed in to false
            Properties.Settings.Default.StaySignedIn = false;
            Properties.Settings.Default.Save();

            // Create a new thread for frmMenu
            tsdAccount.Dispose();
            ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcLogin)));
        }

        #endregion

        #region PasswordList Helper Methods

        /// <summary>
        /// Initialize the Password DataTable
        /// </summary>
        private void InitializePasswordInATable() {
            long passwordID = long.Parse(dgvPasswords[0, dgvPasswords.CurrentCell.RowIndex].Value.ToString());
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE PasswordID={passwordID}";
            _passwordTable = Context.GetDataTable(sqlQuery, "Passwords");


            // Create and assign the users username
            // Check if the username exists
            // Update the UserID in the Password DataTable
            string username = _userTable.Rows[0]["Username"].ToString();
            if (string.IsNullOrEmpty(username)) {
                MessageBox.Show("Couldn't find your username. Please login again.",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

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
        }

        /// <summary>
        /// Populates the DataGridView
        /// </summary>
        private void PopulatePasswordGrid() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT PasswordID, PasswordTitle, PasswordEncrypted " +
                $"FROM Passwords WHERE UserID={_userID}" +
                "ORDER BY PasswordID DESC";

            // Create and assign the DataTable with the Password DataTable
            // Assign the DataTable to the DataView
            // Assign the DataGridView with the DataView
            DataTable passwordTable = Context.GetDataTable(sqlQuery, "Passwords");
            // Setting the column names
            passwordTable.Columns[1].ColumnName = "Title";
            passwordTable.Columns[2].ColumnName = "Password";

            _dvPassword = new DataView(passwordTable);
            dgvPasswords.DataSource = _dvPassword;

            // Setting column sizes
            dgvPasswords.Columns[1].Width = 150;
            dgvPasswords.Columns[2].Width = 150;
        }

        /// <summary>
        /// Initiates the Edit Event
        /// </summary>
        private void EditEvent() {
            // Create and assign the DataGridView Primary Key
            long passwordID = long.Parse(dgvPasswords[0, dgvPasswords.CurrentCell.RowIndex].Value.ToString());

            // Create a new instance of frmPasswordManager (with the Password and User ID)
            // Set the forms parent to this form
            frmPasswordModifier frm = new frmPasswordModifier(passwordID, _userID, Location);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulatePasswordGrid();
            }
        }

        #endregion

        #region PasswordList Events

        // DataGridView Events
        private void DgvPasswords_DoubleClick(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                return;
            }

            EditEvent();
        }
        private void DgvPasswords_SelectionChanged(object sender, EventArgs e) {
            // Check if a cell has been selected
            // Enable the label
            // Else disable the label
            if (dgvPasswords.CurrentCell != null) {
                lblPasswordWarning.Visible = false;
            } else {
                lblPasswordWarning.Visible = true;
            }
        }

        // Button Events
        private void BtnNewPassword_Click(object sender, EventArgs e) {
            // Create a new instance of frmPasswordManager (with the User ID)
            // Set the forms parent to this form
            frmPasswordModifier frm = new frmPasswordModifier(_userID, Location);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulatePasswordGrid();
            }
        }
        private void BtnEditPassword_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            EditEvent();
        }
        private void BtnDeletePassword_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Assign the Password DataTable with Password Table
            InitializePasswordInATable();

            // Delete the row from the table
            _passwordTable.Rows[0].Delete();

            // Save the DataTable and Table
            _passwordTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_passwordTable);

            // Re-populate the grid
            PopulatePasswordGrid();
        }

        #endregion

        #region AccountSettings Helper Methods

        /// <summary>
        /// Check if the user is an admin
        /// </summary>
        private void isAdmin() {
            gbAdminSettings.Visible = bool.Parse(_userTable.Rows[0]["Admin"].ToString());
            _userAdmin = bool.Parse(_userTable.Rows[0]["Admin"].ToString());
        }

        /// <summary>
        /// Initialize the Password DataTable
        /// </summary>
        private void InitializePasswordTable() {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE UserID={_userID}";
            _passwordsTable = Context.GetDataTable(sqlQuery, "Passwords");
        }

        #endregion

        #region AccountSettings Events

        // User Settings
        private void BtnDeleteAccount_Click(object sender, EventArgs e) {
            // Ask the user if they are sure
            DialogResult box = MessageBox.Show("Are you sure you want to delete your account?",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // If yes, continue on
            if (box == DialogResult.Yes) {
                // Delete user
                // Save DataTable
                // Save Table
                _userTable.Rows[0].Delete();
                _userTable.Rows[0].EndEdit();
                Context.SaveDataBaseTable(_userTable);

                // Logout
                Logout();
            }
        }
        private void BtnDeletePasswords_Click(object sender, EventArgs e) {
            // Ask the user if they are sure
            DialogResult box = MessageBox.Show("Are you sure you want to delete your passwords?",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // If yes, continue on
            if (box == DialogResult.Yes) {
                // Initialize the Password DataTable
                InitializePasswordTable();
                if (_passwordsTable.Rows.Count > 0) {
                    // for each row in the Password DataTable
                    foreach (DataRow row in _passwordsTable.Rows) {
                        // Delete the row
                        // Save the row
                        row.Delete();
                        row.EndEdit();
                    }

                    // Save Table
                    Context.SaveDataBaseTable(_passwordsTable);

                    // Let the user know it was completed
                    MessageBox.Show("Passwords Deleted",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                } else {
                    // Provide reason why
                    MessageBox.Show("No passwords to delete",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                }
            }
        }
        private void BtnChangePassword_Click(object sender, EventArgs e) {
            // Check the user entered a new password
            if (!string.IsNullOrEmpty(txtChangePassword.Text)) {
                // Compare the passwords
                // If isEqual = true
                bool isEqual = HashSalt.CompareInputtoPassword(txtChangePassword.Text, _userTable.Rows[0]["PasswordHash"].ToString());
                if (isEqual) {
                    // Provide reason why
                    MessageBox.Show($"\"{txtChangePassword.Text}\" is already your password",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    // Reset the users input back to nothing
                    txtChangePassword.Text = "";
                    return;
                }

                // Converting the inputted password to a Hash Salt
                // Reset the users input back to nothing
                string usersPassword = HashSalt.StringtoHashSalt(txtChangePassword.Text);
                txtChangePassword.Text = "";

                // Adding the new password to the User DataTable
                _userTable.Rows[0]["PasswordHash"] = usersPassword;

                // Set the Save Buttno to enabled
                btnAccountSave.Enabled = true;
            } else {
                // Provide reason why
                MessageBox.Show("Please enter a password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }
        private void BtnAccountSave_Click(object sender, EventArgs e) {
            // Saving User Table
            // Setting the Button Save back to disabled
            Context.SaveDataBaseTable(_userTable);
            btnAccountSave.Enabled = false;

            // Let the user know it was completed
            MessageBox.Show("Account Saved",
                Properties.Settings.Default.ProjectName,
                MessageBoxButtons.OK);
        }

        #endregion
    }
}
