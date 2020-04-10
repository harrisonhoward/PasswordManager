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
    public partial class frmPasswordModifier : Form {
        #region Global Variables

        // Create a variable for the Password and User ID
        // Create a variable for the Password DataTable
        // Create a variable for checking for a new password
        long _passwordID = 0, _userID = 0;
        DataTable _passwordTable;
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
            // Bind data to the form components
            InitializeDatatable();
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

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char) 13) {
                saveChanges();
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
        }

        /// <summary>
        /// Binds data to the text boxes
        /// </summary>
        private void BindControls() {
            // Bind txtTitle with PasswordTitle
            // Bind txtPassword with PasswordEncrypted
            txtTitle.DataBindings.Add("Text", _passwordTable, "PasswordTitle");
            txtPassword.DataBindings.Add("Text", _passwordTable, "PasswordEncrypted");
        }

        /// <summary>
        /// Get the users username
        /// </summary>
        /// <returns>String Username</returns>
        private string getUsername() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT Username FROM Users " +
                $"WHERE UserID={_userID}";
            DataTable passwordTable = Context.GetDataTable(sqlQuery, "Users");

            if (passwordTable.Rows.Count < 1) {
                return null;
            } else {
                return passwordTable.Rows[0]["Username"].ToString();
            }
        }

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

        #endregion
    }
}
