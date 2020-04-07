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
    public partial class frmPasswordList : Form {
        #region Global Variables
        
        // Create a variable for the User ID
        // Create a variable for the Password DataView
        long _userID = 0;
        DataView _dvPassword;

        #endregion

        #region Constructors

        public frmPasswordList(long userID) {
            // Initialize the form components
            // Assign the User ID with the provided User ID
            // Initialize the form
            InitializeComponent();
            _userID = userID;
            InitializeForm();
        }

        public void InitializeForm() {
            // Populate the DataGridView
            PopulateGrid();
        }

        #endregion

        #region Button Events

        private void BtnLogout_Click(object sender, EventArgs e) {
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

        private void ThreadProcLogin() {
            Application.Run(new frmLogin());
        }

        private void ThreadStart(System.Threading.Thread thread) {
            // Start the thread
            // Close the current form
            thread.Start();
            this.Close();
        }

        private void PopulateGrid() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT PasswordID, PasswordTitle, PasswordEncrypted " +
                "FROM Passwords " +
                "ORDER BY PasswordTitle DESC";

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
