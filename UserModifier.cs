using SQLController;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmUserModifier : Form {
        #region Global Variables

        long _userID = 0;
        DataTable _userTable;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of frmUserModifier
        /// </summary>
        /// <param name="userID">The users ID</param>
        /// <param name="location">The location of the form</param>
        public frmUserModifier(long userID, Point location) {
            // Initializes the form components
            // Assign userID to the Global Variable
            // Set the location of the form
            // Initialize the form
            InitializeComponent();
            _userID = userID;
            Location = location;
            InitializeForm();
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

        private void BtnSave_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initializes the User DataTable
        /// </summary>
        private void InitializeDatatable() {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Users " +
                $"WHERE UserID={_userID}";
            _userTable = Context.GetDataTable(sqlQuery, "Users");
        }

        /// <summary>
        /// Binds form components to the DataTable
        /// </summary>
        private void BindControls() {
            txtUsername.DataBindings.Add("Text", _userTable, "Username");
            cbAdmin.DataBindings.Add("Checked", _userTable, "Admin");
        }

        /// <summary>
        /// Save the changes to the DataTable
        /// </summary>
        private void SaveChanges() {
            // Save the DataTable and Table
            _userTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_userTable);

            // Close the form
            Close();
        }

        #endregion
    }
}
