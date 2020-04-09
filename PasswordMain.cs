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
        // Form Size = 816, 489
        #region Global Variables

        // Variables for Main Form
        long _userID = 0;
        DataTable _userTable;
        Panel currentPanel = null;
        ToolStripButton currentButton = null;

        // Variables for Password List
        DataView _dvPassword;
        DataTable _passwordTable;

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
            tscAccount.Items.AddRange(new object[] {
                $"Account: {_userTable.Rows[0]["Username"]}",
                "Logout"
                });
            tscAccount.SelectedIndex = 0;

            // Hide every panel
            panPasswordList.Hide();
        }

        #endregion

        #region ToolStrip Events

        private void TsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // TOOLSTRIP BUTTON - PASSWORDLIST
            if (e.ClickedItem.Equals(tsbPasswordList)) {
                // Check if there is a current shown panel
                // Hide the panel
                if (currentPanel != null) {
                    currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (currentButton != null) {
                    currentButton.Checked = false;
                }
                // Set the current panel
                // Set the current button
                currentPanel = panPasswordList;
                currentButton = tsbPasswordList;

                // Populate the DataGrid on the Panel
                PopulatePasswordGrid();
            }
            // Set the current panel to show
            // Set the current button to active
            currentPanel.Show();
            currentButton.Checked = true;
        }

        #endregion

        #region ToolStripItem Events

        private void TscAccount_SelectedIndexChanged(object sender, EventArgs e) {
            // If they clicked the Logout Item
            if (tscAccount.SelectedIndex == 1) {
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
                ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcLogin)));
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

        #endregion

        #region PasswordList Helper Methods

        /// <summary>
        /// Initialize the Password DataTable
        /// </summary>
        private void InitializePasswordTable() {
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
            InitializePasswordTable();

            // Delete the row from the table
            _passwordTable.Rows[0].Delete();

            // Save the DataTable and Table
            _passwordTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_passwordTable);

            // Re-populate the grid
            PopulatePasswordGrid();
        }

        #endregion
    }
}
