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
    public partial class frmPasswordManager : Form {
        #region Global Variables

        long _passwordID = 0, _userID = 0;
        DataTable _passwordTable;
        bool _isNew = false;

        #endregion

        #region Constructors

        public frmPasswordManager(long userID) {
            InitializeComponent();
            _isNew = true;
            _userID = userID;
            InitializeForm();

            btnAdd.Text = "Add";
        }

        public frmPasswordManager(long passwordID, long userID) {
            InitializeComponent();
            _passwordID = passwordID;
            _userID = userID;
            InitializeForm();

            btnAdd.Text = "Save";
        }

        private void InitializeForm() {
            // Initialize the DataTable
            // Bind data to the form components
            InitializeDatatable();
            BindControls();
        }

        #endregion

        #region Button Events

        private void BtnAdd_Click(object sender, EventArgs e) {
            // Checking if the user has inputted values
            // Showing MessageBox providing reason
            if (string.IsNullOrEmpty(txtTitle.Text)) {
                MessageBox.Show("Please enter a Password Title",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            } else if (string.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Please enter a Password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Get the users username and check if it could be found
            string username = getUsername();
            if (string.IsNullOrEmpty(username)) {
                MessageBox.Show("Couldn't find your username. Please login again.",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }
            _passwordTable.Rows[0]["UserID"] = _userID;

            // Update the PasswordEncrypted with the encrypted password and checking if it encrypted correctly
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

        #region Helper Methods

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
                // Get the users username and check if it could be found
                string username = getUsername();
                if (string.IsNullOrEmpty(username)) {
                    MessageBox.Show("Couldn't find your username. Please login again.",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    return;
                }

                // Update the PasswordEncrypted with the encrypted password and checking if it encrypted correctly
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

        private void BindControls() {
            // Bind txtTitle with PasswordTitle
            // Bind txtPassword with PasswordEncrypted
            txtTitle.DataBindings.Add("Text", _passwordTable, "PasswordTitle");
            txtPassword.DataBindings.Add("Text", _passwordTable, "PasswordEncrypted");
        }

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

        #endregion
    }
}
