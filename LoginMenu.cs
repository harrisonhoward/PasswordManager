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
using PasswordEncryptor;

namespace PasswordManager {
    /// <summary>
    /// Login Screen. Main Form
    /// </summary>
    public partial class frmLogin : Form {
        #region Global Variables

        // Create a variable for User DataTable
        // Create variables for User Input for Username and Password
        // Create a variable for the UserID
        DataTable _userTable;
        string _usersUsername = "", _usersPassword = "";
        long _userID = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of frmLogin
        /// </summary>
        public frmLogin() {
            // Initializes the form components
            InitializeComponent();
        }

        #endregion

        #region Button Events

        private void BtnLogin_Click(object sender, EventArgs e) {
            // Checking if the user has inputted values
            // Showing MessageBox providing reason
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
                ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcPasswordList)));
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

        #endregion

        #region Form Events

        private void FrmLogin_Load(object sender, EventArgs e) {
            // Create and assign LoginDetails DataTable
            DataTable loginTable = Context.GetDataTable("LoginDetails");

            // If the DataTable contains rows
            // Login using the UserID
            if (loginTable.Rows.Count > 0) {
                _userID = long.Parse(loginTable.Rows[0]["UserID"].ToString());
                ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcPasswordList)));
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (cbSignedIn.Checked) {
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

        #region LinkLabel Events

        private void LnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Create a new instance of frmNewUser
            frmNewUser frm = new frmNewUser();
            // Show the form
            frm.ShowDialog();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Runs a form
        /// </summary>
        private void ThreadProcPasswordList() {
            Application.Run(new frmPasswordList(_userID));
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
        private void InitializeUserTable() {
            // Create and assign a new SQL Query
            // Assign the User DataTable with the User Table
            string sqlQuery = 
                "SELECT * FROM Users " +
                $"WHERE Username='{_usersUsername}'";
            _userTable = Context.GetDataTable(sqlQuery, "Users", true);
        }

        #endregion
    }
}
