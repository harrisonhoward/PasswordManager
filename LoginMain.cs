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
    public partial class frmLogin : Form {
        #region Global Variables

        // Create a variable for User DataTable
        // Create variables for User Input for Username and Password
        // Create a variable for the UserID
        /* 
         * Create a variable for checking the User DataTable
         * contains the User Input Username
        */
        DataTable _userTable;
        string _usersUsername = "", _usersPassword = "";
        long _userID = 0;
        bool _tableContains = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of our form
        /// </summary>
        public frmLogin() {
            // Initializes the form components
            InitializeComponent();
            // Hides the Create Panel
            panCreate.Hide();
            Text = "Login";
        }

        #endregion

        #region Form Events

        private void FrmLogin_Load(object sender, EventArgs e) {
            // Create and assign LoginDetails DataTable
            DataTable loginTable = Context.GetDataTable("LoginDetails");

            // If the DataTable contains rows
            // Login using the UserID
            if (loginTable.Rows.Count > 0) {
                _userID = long.Parse(loginTable.Rows[0]["UserID"].ToString());
                ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcPasswordMain)));
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            // Check if Stay Signed In is check and a userID has been set
            if (cbSignedIn.Checked && _userID != 0) {
                // Create and assign LoginDetails DataTable
                DataTable loginTable = Context.GetDataTable("LoginDetails");

                // Create a new row in the DataTable
                // Change the UserID to the saved UserID
                // Save the row
                // Add the row
                DataRow row = loginTable.NewRow();
                row["UserID"] = _userID;
                row.EndEdit();
                loginTable.Rows.Add(row);

                // Save the table
                Context.SaveDataBaseTable(loginTable);
            }
        }

        #endregion

        #region Button Events

        private void BtnLogin_Click(object sender, EventArgs e) {
            // Checking if the user has inputted values
            // Showing MessageBox providing reason
            if (string.IsNullOrEmpty(txtMainUsername.Text)) {
                MessageBox.Show("Please enter a username",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            } else if (string.IsNullOrEmpty(txtMainPassword.Text)) {
                MessageBox.Show("Please enter a password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Assign the User Inputted Username and Password to the Global Variables
            _usersUsername = txtMainUsername.Text;
            _usersPassword = txtMainPassword.Text;

            // Initialize the User DataTable
            InitializeUserTable(false);

            // Check if the username exists
            // Show a MessageBox
            if (_userTable.Rows.Count < 1) {
                MessageBox.Show($"No user by the username '{_usersUsername}' (case sensitive) was found",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Creating a string for the password hash
            string userPasswordHash = _userTable.Rows[0]["PasswordHash"].ToString();

            // Comparing the users input to the hash password
            bool isEquals = HashSalt.CompareInputtoPassword(_usersPassword, userPasswordHash);

            // Checking if isEquals is true
            // Assign userID and starting PasswordList (with UserID)
            // Else Showing a MessageBox and resetting the variables
            if (isEquals) {
                _userID = long.Parse(_userTable.Rows[0]["UserID"].ToString());
                ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcPasswordMain)));
            } else {
                MessageBox.Show("Password was incorrect",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                _usersUsername = "";
                _usersPassword = "";
                _userTable = null;
                return;
            }
        }

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

            // Comparing the Password with Confirm Password
            // If not show a MessageBox
            if (!txtPassword.Text.Equals(txtConfirm.Text)) {
                MessageBox.Show("Confirm Password does not match Password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Assign the User Inputted Username and Password to the Global Variables
            _usersUsername = txtUsername.Text;
            _usersPassword = txtPassword.Text;

            // Initialize the User DataTable
            InitializeUserTable(true);

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

            // Show the Login Panel
            panLogin.Show();
            Text = "Login";


            // Hide the Create Panel
            panCreate.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            // Closes the form
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            // Show the Login Panel
            panLogin.Show();
            Text = "Login";


            // Hide the Create Panel
            panCreate.Hide();
        }

        #endregion

        #region LinkLabel Events

        private void LnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Hide the Login Panel
            panLogin.Hide();

            // Show the Create Panel
            panCreate.Show();
            Text = "Create an account";
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Runs a form
        /// </summary>
        private void ThreadProcPasswordMain() {
            Application.Run(new frmPasswordMain(_userID));
        }

        /// <summary>
        /// Starts a new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        private void ThreadStart(System.Threading.Thread thread) {
            // Start the new thread
            // Close the current form
            thread.Start();
            Close();
        }

        /// <summary>
        /// Initializes the User DataTable
        /// </summary>
        private void InitializeUserTable(bool isCreate) {
            // If isCreate = true
            // Create a editable DataTable
            // Else Get the a single user
            if (isCreate) {
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
            } else {
                // Create and assign a new SQL Query
                // Assign the User DataTable with the User Table
                string sqlQuery =
                    "SELECT * FROM Users " +
                    $"WHERE Username='{_usersUsername}'";
                _userTable = Context.GetDataTable(sqlQuery, "Users", true);
            }
        }

        #endregion
    }
}
