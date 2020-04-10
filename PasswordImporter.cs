using Encryptor;
using SQLController;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmPasswordImporter : Form {
        #region Global Variables

        long _userID = 0;
        DataTable _allPasswordsTable, _passwordsTable, _importTable;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of frmPasswordImporter
        /// </summary>
        /// <param name="userID">The users id</param>
        public frmPasswordImporter(long userID, Point location) {
            // Initalize the form components
            // Set frame location
            // Assign userID to Global Variable
            // Initialize the User's Passwords
            // Set ComboBox to -1 SelectedIndex
            InitializeComponent();
            Location = location;
            _userID = userID;
            InitializeUserPasswords();
            cbType.SelectedIndex = -1;
        }

        #endregion

        #region Button Events

        private void BtnImport_Click(object sender, EventArgs e) {
            if (cbType.SelectedIndex == 0) {
                PasswordManagerImport();
            } else {
                MessageBox.Show("Cancelled. No item selected.",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
            // Create a new thread for frmPasswordMain
            ThreadStart(new Thread(new ThreadStart(ThreadProcPasswordMain)));
        }

        #endregion

        #region Import Methods

        private void PasswordManagerImport() {
            // Import the CSV File
            PasswordManagerFileReader();
            // Check if it worked
            if (_importTable.Rows.Count < 1) {
                return;
            }

            // Ask the user if they want to remove the previous passwords
            DialogResult box = MessageBox.Show("Click Yes if you want the previous passwords deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);

            // Check if the user clicked yes
            if (box == DialogResult.Yes) {
                DeletePasswords();
            }

            // Initialize the Passwords DataTable with the correct passwords
            InitializeAllPasswords();

            // For each row in the File Passwords
            foreach (DataRow row in _importTable.Rows) {
                // Create a new row
                DataRow newRow = _allPasswordsTable.NewRow();
                // Assign PasswordID, UserID and PasswordTitle
                newRow["PasswordID"] = int.Parse(_allPasswordsTable.Rows[_allPasswordsTable.Rows.Count - 1]["PasswordID"].ToString()) + 1;
                newRow["UserID"] = _userID;
                newRow["PasswordTitle"] = row["Title"];
                // Check if isEncrypted is false
                if (!bool.Parse(row["isEncrypted"].ToString())) {
                    // Update PasswordEncrypted
                    newRow["PasswordEncrypted"] = Encryption.Decrypt(row["Password"].ToString(), row["Username"].ToString());
                } else {
                    // Update PasswordEncrypted
                    newRow["PasswordEncrypted"] = row["Password"];
                }
                // Save the row
                newRow.EndEdit();
                _allPasswordsTable.Rows.Add(newRow);

                // Save the Table
                // Populate Grid
                Context.SaveDataBaseTable(_allPasswordsTable);
            }
        }

        #endregion

        #region File Readers

        /// <summary>
        /// Imports Passwords CSV File
        /// </summary>
        private void PasswordManagerFileReader() {
            // Create a new instance of List String
            DataTable PasswordsList = new DataTable();
            // Add the columns
            PasswordsList.Columns.Add("Username");
            PasswordsList.Columns.Add("Title");
            PasswordsList.Columns.Add("Password");
            PasswordsList.Columns.Add("isEncrypted");

            // Create a new String Array containing all the lines
            string[] fileLines = File.ReadAllLines($"{getUsername()}Passwords.csv");

            // Try to read the file
            // Catch any errors
            try {
                // For each line in the file lines
                foreach (string line in fileLines) {
                    // Create a new variable for containing all the entries on the lines
                    string[] lineSplit = line.Split(new string[] { ";" }, StringSplitOptions.None);
                    // Create variables for each entry
                    string Username = lineSplit[0];
                    string Title = lineSplit[1];
                    string Password = lineSplit[2];
                    string isEncrypted = lineSplit[3];

                    // Add the entries to the Passwords List
                    // Save row
                    PasswordsList.Rows.Add(Username, Title, Password, isEncrypted);
                }
            } catch (Exception err) {
                // Check if there is rows
                if (PasswordsList.Rows.Count > 0) {
                    // For each row delete and save
                    // This is to stop the program
                    foreach (DataRow row in PasswordsList.Rows) {
                        row.Delete();
                    }
                }
                // Let the user know the read file failed
                MessageBox.Show("Error: Reading the CSV File. Message: " + err.Message);
            } finally {
                // Check if there is rows
                if (PasswordsList.Rows.Count > 0) {
                    // For each row end edit
                    foreach (DataRow row in PasswordsList.Rows) {
                        row.EndEdit();
                    }
                } else {
                    MessageBox.Show("Failed to import passwords",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                }
            }

            // Assign Import DataTable as PasswordsList
            _importTable = PasswordsList;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Run a form
        /// </summary>
        private void ThreadProcPasswordMain() {
            Application.Run(new frmPasswordMain(_userID));
        }
        /// <summary>
        /// Start a new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        private void ThreadStart(Thread thread) {
            // Start the thread
            // Close the current form
            thread.Start();
            this.Close();
        }

        /// <summary>
        /// Initializes the User's Passwords DataTable
        /// </summary>
        private void InitializeUserPasswords() {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE UserID={_userID}";
            _passwordsTable = Context.GetDataTable(sqlQuery, "Passwords");
        }

        /// <summary>
        /// Initialize the All Passwords DataTable
        /// </summary>
        private void InitializeAllPasswords() {
            // Assign the All Passwords DataTable
            _allPasswordsTable = Context.GetDataTable("Passwords");
        }

        /// <summary>
        /// Delete the User's Passwords
        /// </summary>
        private void DeletePasswords() {
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
            }
        }

        /// <summary>
        /// Get the user's username
        /// </summary>
        /// <param name="userID">The provided UserID</param>
        /// <returns>Returns the username</returns>
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

        #endregion
    }
}
