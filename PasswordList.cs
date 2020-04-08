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
    /// Allows the user to view all their passwords
    /// </summary>
    public partial class frmPasswordList : Form {
        #region Global Variables

        // Create a variable for the User ID
        // Create a variable for the Password DataView
        long _userID = 0;
        DataView _dvPassword;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of frmPasswordList
        /// </summary>
        /// <param name="userID">The user logging in</param>
        public frmPasswordList(long userID) {
            // Initialize the form components
            // Assign the User ID with the provided User ID
            // Initialize the form
            InitializeComponent();
            _userID = userID;
            InitializeForm();
        }

        /// <summary>
        /// Initalizes the Form
        /// </summary>
        public void InitializeForm() {
            // Populate the DataGridView
            PopulateGrid();
        }

        #endregion

        #region Button Events

        private void BtnLogout_Click(object sender, EventArgs e) {
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

        private void BtnNew_Click(object sender, EventArgs e) {
            // Create a new instance of frmPasswordManager (with the User ID)
            frmPasswordManager frm = new frmPasswordManager(_userID);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateGrid();
            }
        }

        #endregion

        #region TextBox Events

        private void TxtSearch_TextChanged(object sender, EventArgs e) {
            // Assign the DataView RowFilter
            _dvPassword.RowFilter = $"Title LIKE '%{txtSearch.Text}%'";
        }

        #endregion

        #region DataGridView Events

        private void DgvPasswords_DoubleClick(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                return;
            }

            // Create and assign the DataGridView Primary Key
            long passwordID = long.Parse(dgvPasswords[0, dgvPasswords.CurrentCell.RowIndex].Value.ToString());

            // Create a new instance of frmPasswordManager (with the Password and User ID)
            frmPasswordManager frm = new frmPasswordManager(passwordID, _userID);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateGrid();
            }
        }

        #endregion

        #region Helper Methods

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
        /// Populates the DataGridView
        /// </summary>
        private void PopulateGrid() {
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

        #endregion
    }
}
