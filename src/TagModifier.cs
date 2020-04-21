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
    public partial class frmTagModifier : Form {
        #region Global Variables

        // Create a variable for the Tag and User ID
        // Create a variable for the Tag DataTable
        // Create a variable for checking for a new tag
        long _tagID = 0, _userID = 0;
        DataTable _tagTable;
        bool _isNew = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize the frmTagModifier
        /// </summary>
        /// <param name="userID">The user's ID</param>
        /// <param name="location">Previous forms location</param>
        public frmTagModifier(long userID, Point location) {
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
        /// Initialize the frmTagModifier
        /// </summary>
        /// <param name="tagID">The tag's ID</param>
        /// <param name="userID">The user's ID</param>
        /// <param name="location">Previous form location</param>
        public frmTagModifier(long tagID, long userID, Point location) {
            // Initialize the form components
            // Assign the tagID to the Global Variable
            // Assign the userID to the Global Variable
            // Initialize the form
            InitializeComponent();
            _tagID = tagID;
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

        #region Key Events

        private void KeyEvent_KeyDown(object sender, KeyEventArgs e) {
            // Check if the user pressed Enter
            if (e.KeyCode == Keys.Enter) {
                // Save changes
                // Set the DialogResult to OK
                saveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void KeyEvent_KeyPress(object sender, KeyPressEventArgs e) {
            // Check if the user pressed Enter
            if (e.KeyChar == (char)13) {
                // Set the key handled to true
                e.Handled = true;
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initializes the Tag DataTable
        /// </summary>
        private void InitializeDatatable() {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Tags " +
                $"WHERE TagID={_tagID}";
            _tagTable = Context.GetDataTable(sqlQuery, "Tags");

            // Check if _isNew is true
            // Else decrypt the password
            if (_isNew) {
                // Create and assign a new DataRow
                // Assign an empty row to the Passwords DataTable
                DataRow row = _tagTable.NewRow();
                _tagTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Binds data to the text boxes
        /// </summary>
        private void BindControls() {
            // Bind txtDisplay with TagDisplay
            // Bind txtDescription with TagDescription
            txtDisplay.DataBindings.Add("Text", _tagTable, "TagDisplay");
            txtDescription.DataBindings.Add("Text", _tagTable, "TagDescription");
        }

        /// <summary>
        /// Saves any changes to the DataTable (including creation)
        /// </summary>
        private void saveChanges() {
            // Checking if the user has inputted values
            // Showing MessageBox providing reason
            if (string.IsNullOrEmpty(txtDisplay.Text)) {
                MessageBox.Show("Please enter a display for the tag",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Updating TagDisplay and TagDescription
            // Key event doesn't save the text boxes sometimes
            _tagTable.Rows[0]["TagDisplay"] = txtDisplay.Text;
            _tagTable.Rows[0]["TagDescription"] = txtDescription.Text;

            // Update the UserID in the Tag DataTable
            _tagTable.Rows[0]["UserID"] = _userID;

            // Save the DataTable and Table
            _tagTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_tagTable);

            // Close form
            Close();
        }

        #endregion
    }
}
