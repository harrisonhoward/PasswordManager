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
    /// <summary>
    /// Allows the creation of a new user
    /// </summary>
    public partial class frmNewUser : Form {
        #region Global Variables

        // Create a variable for the User DataTable
        // Create variables for the User Input for Username and Password
        /* 
         * Create a variable for checking the User DataTable
         * contains the User Input Username
         */
        DataTable _userTable;
        string _usersUsername = "", _usersPassword = "";
        bool _tableContains = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of frmNewUser
        /// </summary>
        public frmNewUser() {
            // Initializes the form components
            InitializeComponent();
        }

        #endregion

        #region Button Events

        private void BtnCreate_Click(object sender, EventArgs e) {
            // Checking if the user has inputted values
            // Showing a MessageBox with the provided reason
            if (string.IsNullOrEmpty(txtUsername.Text)) {
                MessageBox.Show("Please enter a username",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            } else if (string.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Please enter a password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Assign the User Inputted Username and Password to the Global Variables
            _usersUsername = txtUsername.Text;
            _usersPassword = txtPassword.Text;

            // Initialize the User DataTable
            InitializeUserTable();

            // Check if the username exists
            // Show a MessageBox
            if (_tableContains) {
                MessageBox.Show($"A user by the username '{_usersUsername}' already exists",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Converting the inputted password to a Hash Salt
            _usersPassword = HashSalt.StringtoHashSalt(_usersPassword);

            // Adding a new row to User DataTable
            // Inputted the new data for the row before adding it
            DataRow row = _userTable.NewRow();
            row["UserID"] = _userTable.Rows.Count + 1;
            row["Username"] = _usersUsername;
            row["PasswordHash"] = _usersPassword;
            _userTable.Rows.Add(row);


            // Create and assign the column names
            string columnNames = "UserID, Username, PasswordHash";

            // Create and assign the column values
            string columnValues = 
                $"{row["UserID"]}, " +
                $"'{row["Username"]}', " +
                $"'{row["PasswordHash"]}'";

            // Insert the record
            Context.InsertRecord("Users", columnNames, columnValues);

            // Close form
            Close();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initializes the User DataTable
        /// </summary>
        private void InitializeUserTable() {
            // Create and assign a new SQL Query
            // Assign the User DataTable with the User Table
            _userTable = Context.GetDataTable("Users");

            // For each row in the User DataTable
            // If the Username column in the row is equals to the User Input Username
            // Set the tableContains global variable to true
            foreach (DataRow row in _userTable.Rows) {
                if (row["Username"].Equals(_usersUsername)) {
                    _tableContains = true;
                }
            }
        }

        #endregion
    }
}
