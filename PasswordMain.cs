using Encryptor;
using SQLController;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmPasswordMain : Form {
        #region Global Variables

        // Variables for Main Form
        long _userID = 0;
        long _mainUserID = -1;
        DataTable _userTable;
        Panel _currentPanel = null;
        ToolStripButton _currentButton = null;

        // Variables for Password List
        DataView _dvPassword;
        DataTable _passwordTable;
        string[] _rowFilters = new string[2];

        // Variables for Account Settings
        bool _userAdmin;
        DataView _dvUsers;
        DataTable _passwordsTable, _tagsTable;

        // Variables for the Tags List
        DataView _dvTag;
        DataTable _tagTable;

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

        /// <summary>
        /// Creates a new instance of PasswordMain
        /// </summary>
        /// <param name="userID">Provided User ID</param> 
        public frmPasswordMain(long userID, long mainUserID) {
            // Initialize the form components
            // Assign the User ID with the provided User ID
            // Assign the Main User ID with the provider Main User ID
            // Initialize the form
            InitializeComponent();
            _userID = userID;
            _mainUserID = mainUserID;
            InitializeForm();
        }

        private void InitializeForm() {
            // Initialize the User DataTable
            InitializeUserTable();

            // Create the Account Combobox with Items
            // Set the SelectedIndex to 0
            tsdAccount.Text = $"Account: {_userTable.Rows[0]["Username"]}";
            tsdAccount.Select();

            // Hide every panel
            panPasswordList.Hide();
            panAccountSettings.Hide();
            panTagsList.Hide();
        }

        #endregion

        #region ToolStrip Events

        private void TsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem.Equals(tsbPasswordList)) {
                // PasswordList

                // Check if there is a current shown panel
                // Hide the panel
                if (_currentPanel != null) {
                    _currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (_currentButton != null) {
                    _currentButton.Checked = false;
                }
                // Set the current panel
                // Set the current button
                _currentPanel = panPasswordList;
                _currentButton = tsbPasswordList;

                // Populate the DataGrid on the Panel
                // Populate the ComboBox
                // Make sure first item is selected
                PopulatePasswordGrid();
                PopulateComboBox();
                cboTags.SelectedIndex = 0;
            } else if (e.ClickedItem.Equals(tsbAccount)) {
                // AccountSettings

                // Check if there is a current shown panel
                // Hide the panel
                if (_currentPanel != null) {
                    _currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (_currentButton != null) {
                    _currentButton.Checked = false;
                }

                // Set the current panel
                // Set the current button
                _currentPanel = panAccountSettings;
                _currentButton = tsbAccount;

                // Assign the CheckBox to the saved data
                cbPasswordRequest.Checked = bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString());

                // Check if the user is an admin
                // Disable save button
                isAdmin();
                btnAccountSave.Enabled = false;
            } else if (e.ClickedItem.Equals(tsbTagsList)) {
                // TagsList

                // Check if there is a current shown panel
                // Hide the panel
                if (_currentPanel != null) {
                    _currentPanel.Hide();
                }
                // Check if there is a current active button
                // Unactive the button
                if (_currentButton != null) {
                    _currentButton.Checked = false;
                }

                // Set the current panel
                // Set the current button
                _currentPanel = panTagsList;
                _currentButton = tsbTagsList;

                PopulateTagGrid();
            }
            // Set the current panel to show
            // Set the current button to active
            if (e.ClickedItem.GetType().Equals(typeof(ToolStripButton))) {
                _currentPanel.Show();
                _currentButton.Checked = true;
            }
        }

        #endregion

        #region ToolStripItem Events

        private void TsdAccount_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Checking if they clicked logout
            if (e.ClickedItem.Equals(tsdiLogout)) {
                // Logout
                Logout();
            }
        }

        #endregion

        #region Button Events

        private void BtnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnSignIn_Click(object sender, EventArgs e) {
            Thread frm = new Thread(new ThreadStart(ThreadProcPasswordMain));
            frm.Start();
        }

        #endregion

        #region Main Helper Methods

        /// <summary>
        /// Run a form
        /// </summary>
        private void ThreadProcLogin() {
            Application.Run(new frmLogin());
        }
        private void ThreadProcPasswordImport() {
            Application.Run(new frmPasswordImporter(_userID, Location));
        }
        private void ThreadProcPasswordMain() {
            Application.Run(new frmPasswordMain(long.Parse(txtUserSearch.Text), 0));
        }

        /// <summary>
        /// Start a new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        private void ThreadStart(Thread thread) {
            // Start the thread
            // Close the current form
            thread.Start();
            Close();
        }
        /// <summary>
        /// Start a new thread with STA
        /// </summary>
        /// <param name="thread">The new thread</param>
        private Thread ThreadStartSTA(Thread thread) {
            // Settting the Thread to STA to allow the use of Import Event
            thread.SetApartmentState(ApartmentState.STA);
            // Start the thread using our new object DialogResult.OK
            thread.Start();
            return thread;
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

        /// <summary>
        /// Logs out of the form
        /// </summary>
        private void Logout() {
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
            tsdAccount.Dispose();
            ThreadStart(new Thread(new ThreadStart(ThreadProcLogin)));
        }

        /// <summary>
        /// Get the user's username
        /// </summary>
        /// <param name="userID">The provided UserID</param>
        /// <returns>Returns the username</returns>
        private string getUsername(long userID) {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT UserID, Username FROM Users " +
                $"WHERE UserID={userID}";
            DataTable userTable = Context.GetDataTable(sqlQuery, "Users");

            if (userTable.Rows.Count < 1) {
                return null;
            } else {
                return userTable.Rows[0]["Username"].ToString();
            }
        }

        #endregion

        #region PasswordList Helper Methods

        /// <summary>
        /// Initialize the Password DataTable
        /// </summary>
        private void InitializePasswordInATable(long passwordID) {
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
                "SELECT * FROM Passwords " +
                $"WHERE UserID={_userID} " +
                "ORDER BY PasswordID DESC";

            // Create and assign the DataTable with the Password DataTable
            // Assign the DataTable to the DataView
            // Assign the DataGridView with the DataView
            DataTable passwordTable = Context.GetDataTable(sqlQuery, "Passwords");

            // Add a new column for holding TagDisplay
            DataColumn newColumn = new DataColumn();
            newColumn.ColumnName = "Tag";
            newColumn.DataType = typeof(string);
            newColumn.MaxLength = 120;
            passwordTable.Columns.Add(newColumn);

            // Setting the column names
            passwordTable.Columns[3].ColumnName = "Title";
            passwordTable.Columns[4].ColumnName = "Username";
            passwordTable.Columns[5].ColumnName = "Password";

            // For each row, changing TagID to TagDisplay
            foreach (DataRow row in passwordTable.Rows) {
                if (row["TagID"] is DBNull) {
                    row["Tag"] = "";
                } else {
                    string tagDisplay = GetTagDisplay(long.Parse(row["TagID"].ToString()));
                    if (string.IsNullOrEmpty(tagDisplay)) {
                        row["Tag"] = "";
                    } else {
                        row["Tag"] = tagDisplay;
                    }
                }
            }

            _dvPassword = new DataView(passwordTable);
            dgvPasswords.DataSource = _dvPassword;

            // Setting the UserID and TagID Column as invisible
            dgvPasswords.Columns[1].Visible = false;
            dgvPasswords.Columns[2].Visible = false;

            // Setting column 
            dgvPasswords.Columns[3].Width = 125;
            dgvPasswords.Columns[4].Width = 125;
            dgvPasswords.Columns[5].Width = 125;
            dgvPasswords.Columns[6].Width = 100;
        }

        /// <summary>
        /// Binds All Tags to the ComboBox
        /// </summary>
        private void PopulateComboBox() {
            // Check if the ComboBox is already populated
            if (cboTags.Items.Count > 0) {
                // Clear all the items
                cboTags.Items.Clear();
            }

            // Make sure the first item is None
            cboTags.Items.Insert(0, "None");

            // Create and assign a new SQL Query
            // Create and assign a new DataTable
            string sqlQuery =
                $"SELECT TagID, TagDisplay FROM Tags " +
                $"WHERE UserID={_userID}";
            DataTable tagTable = Context.GetDataTable(sqlQuery, "Tags");

            foreach (DataRow row in tagTable.Rows) {
                cboTags.Items.Add(row["TagDisplay"]);
            }
        }

        /// <summary>
        /// Initiates the Edit Event
        /// </summary>
        private void EditPasswordEvent() {
            // Check if the user requests a password
            if (bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString())) {
                // Ask for password
                // If the request returned false, cancel method
                bool success = RequestPassword(_userTable.Rows[0]);
                if (!success) {
                    return;
                }
            }

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

        /// <summary>
        /// Returns the TagDisplay of a TagID
        /// </summary>
        /// <param name="tagID">The id of the tag</param>
        private string GetTagDisplay(long tagID) {
            // Create a variable for holding the string
            string tagDisplay = null;

            // Create and assign a new SQL Query
            // Assign the query to a temp datatable
            string sqlQuery =
                "SELECT TagID, TagDisplay FROM Tags " +
                $"WHERE TagID={tagID}";
            DataTable tagTable = Context.GetDataTable(sqlQuery, "Tags");

            // Check if the tag exists
            // Assign TagDisplay to the Local Variable
            if (tagTable.Rows.Count > 0) {
                tagDisplay = tagTable.Rows[0]["TagDisplay"].ToString();
            }

            // Return tagDisplay
            return tagDisplay;
        }

        /// <summary>
        /// Filters the DataView
        /// </summary>
        /// <param name="rowFilter">String array containing the filters</param>
        private void PasswordsFilterRow() {
            // Create a variable for the filter
            string filterString;

            // If Text is null. Filter by tags
            // If Tags is null. Filter by Text
            // If Both are null. Filter by nothing
            // Else Filter by Both
            if (_rowFilters[0] == null
                && _rowFilters[1] != null) {
                filterString = _rowFilters[1];
            } else if (_rowFilters[1] == null
                && _rowFilters[0] != null) {
                filterString = _rowFilters[0];
            } else if (_rowFilters[0] == null
                && _rowFilters[1] == null) {
                filterString = "";
            } else {
                filterString = $"{_rowFilters[0]} AND {_rowFilters[1]}";
            }

            // Assign the filterString to the DataView
            _dvPassword.RowFilter = filterString;
        }

        #endregion

        #region PasswordList Events

        // TextBox Events
        private void TxtPasswordSearch_TextChanged(object sender, EventArgs e) {
            if (txtPasswordSearch.Text.Length > 0) {
                // Assign the text filter
                // Assign the DataView RowFilter
                _rowFilters[0] =
                    $"Title LIKE '%{txtPasswordSearch.Text}%' " +
                    $"OR Username LIKE '%{txtPasswordSearch.Text}%'";
                PasswordsFilterRow();
            } else {
                _rowFilters[0] = null;
                PasswordsFilterRow();
            }
        }

        // CheckBox Events
        private void CboTags_SelectedIndexChanged(object sender, EventArgs e) {
            // Make sure there is a selected value
            if (_dvPassword.Table.Rows.Count > 0) {
                // Create a variable for the selected value
                string tagValue = (string)cboTags.SelectedItem;

                if (cboTags.SelectedIndex > 0) {
                    _rowFilters[1] = $"Tag='{tagValue}'";
                } else {
                    _rowFilters[1] = null;
                }
                PasswordsFilterRow();
            }
        }

        // DataGridView Events
        private void DgvPasswords_DoubleClick(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                return;
            }

            EditPasswordEvent();
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

            EditPasswordEvent();
        }
        private void BtnDeletePassword_Click(object sender, EventArgs e) {
            // Check if the user requests a password
            if (bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString())) {
                // Ask for password
                // If the request returned false, cancel method
                bool success = RequestPassword(_userTable.Rows[0]);
                if (!success) {
                    return;
                }
            }

            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvPasswords.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Create and assign the password id
            long passwordID = long.Parse(dgvPasswords[0, dgvPasswords.CurrentCell.RowIndex].Value.ToString());
            // Assign the Password DataTable with Password Table
            InitializePasswordInATable(passwordID);

            // Delete the row from the table
            _passwordTable.Rows[0].Delete();

            // Save the DataTable and Table
            _passwordTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_passwordTable);

            // Re-populate the grid
            PopulatePasswordGrid();
        }
        private void BtnPasswordExport_Click(object sender, EventArgs e) {
            // Check if the user requests a password
            if (bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString())) {
                // Ask for password
                // If the request returned false, cancel method
                bool success = RequestPassword(_userTable.Rows[0]);
                if (!success) {
                    return;
                }
            }

            if (_dvPassword.Table.Rows.Count < 1) {
                MessageBox.Show("No passwords to export",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Ask the user if they want the passwords to be encrypted
            DialogResult box = MessageBox.Show("Click Yes for the exported passwords to be encrypted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // Create and assign a new StringBuilder
            StringBuilder sbExport = new StringBuilder();

            // Check if user clicked Yes
            if (box == DialogResult.Yes) {
                // For each DataRowView in Password DataView
                foreach (DataRowView row in _dvPassword) {
                    string userName = getUsername(long.Parse(row["UserID"].ToString()));
                    sbExport.AppendLine(
                        $"{userName};" +
                        $"{row["Title"]};" +
                        $"{row["Username"]};" +
                        $"{row["Password"]};" +
                        $"{row["TagID"]};" +
                        true);
                }
            } else {
                // For each DataRowView in Password DataView
                foreach (DataRowView row in _dvPassword) {
                    string userName = getUsername(long.Parse(row["UserID"].ToString()));
                    sbExport.AppendLine(
                        $"{userName};" +
                        $"{row["Title"]};" +
                        $"{row["Username"]};" +
                        $"{Encryption.Decrypt(row["Password"].ToString(), getUsername(long.Parse(row["UserID"].ToString())))};" +
                        $"{row["TagID"]};" +
                        false);
                }
            }

            // Write the StringBuilder to the PasswordManager CSV
            // Show a MessageBox
            File.WriteAllText(Application.StartupPath + $@"\{getUsername(_userID)}Passwords.csv", sbExport.ToString());
            MessageBox.Show("Passwords exported to CSV", Properties.Settings.Default.ProjectName);
        }
        private void BtnPasswordImport_Click(object sender, EventArgs e) {
            // Check if the user requests a password
            if (bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString())) {
                // Ask for password
                // If the request returned false, cancel method
                bool success = RequestPassword(_userTable.Rows[0]);
                if (!success) {
                    return;
                }
            }

            // Create a new thread using ThreadStart.
            // Using that thread we will join it so we execute Populate Grid at the right time
            Thread thread = ThreadStartSTA(new Thread(new ThreadStart(ThreadProcPasswordImport)));
            thread.Join();
            PopulatePasswordGrid();
        }

        #endregion

        #region AccountSettings Helper Methods

        /// <summary>
        /// Check if the user is an admin
        /// </summary>
        private void isAdmin() {
            // Set the Admin Settings based on the user's admin status
            // Set the Admin Variable based on the user's admin status
            // Populate the admin grid
            // Check if the user's id is 0 then show the signin button
            gbAdminSettings.Visible = bool.Parse(_userTable.Rows[0]["Admin"].ToString());
            _userAdmin = bool.Parse(_userTable.Rows[0]["Admin"].ToString());
            PopulateAdminGrid();
            if (_userID == 0) {
                btnSignIn.Visible = true;
            }
        }

        /// <summary>
        /// Initialize the Password DataTable
        /// </summary>
        private void InitializePasswordTable(long userID) {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Passwords " +
                $"WHERE UserID={userID}";
            _passwordsTable = Context.GetDataTable(sqlQuery, "Passwords");
        }

        /// <summary>
        /// Initialize the Tag DataTable
        /// </summary>
        private void InitializeTagTable(long userID) {
            // Create and assign a new SQL Query
            // Assign the Password DataTable with the Password Table
            string sqlQuery =
                "SELECT * FROM Tags " +
                $"WHERE UserID={userID}";
            _tagsTable = Context.GetDataTable(sqlQuery, "Tags");
        }

        /// <summary>
        /// Gets all the Admins
        /// </summary>
        private int GetAllAdmins() {
            // Create and assign a new SQL Query
            // Create and assign the Admin DataTable
            string sqlQuery =
                "SELECT * FROM Users " +
                $"WHERE UserID!={_userID} AND UserID!=0 AND Admin=1";
            DataTable adminTable = Context.GetDataTable(sqlQuery, "Users");

            // Return the adminTable Row Count
            return adminTable.Rows.Count;
        }

        /// <summary>
        /// Deletes all the passwords
        /// </summary>
        private void DeletePasswords(long userID) {
            // Initialize the Password DataTable
            InitializePasswordTable(userID);
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

                // Let the user know it was completed
                MessageBox.Show("Passwords Deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            } else {
                // Get the username of the user
                string userName = getUsername(userID);

                // Convert the username into You have or User has
                if (userID == _userID) {
                    userName = "You have";
                } else {
                    userName += " has";
                }
                // Provide reason why
                MessageBox.Show($"{userName} no passwords to delete",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Deletes all the tags
        /// </summary>
        private void DeleteTags(long userID) {
            // Initialize the Tag DataTable
            InitializeTagTable(userID);
            if (_tagsTable.Rows.Count > 0) {
                // for each row in the Tag DataTable
                foreach (DataRow row in _tagsTable.Rows) {
                    // Delete the row
                    // Save the row
                    row.Delete();
                    row.EndEdit();
                }

                // Save Table
                Context.SaveDataBaseTable(_tagsTable);

                // Let the user know it was completed
                MessageBox.Show("Tags Deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            } else {
                // Provide reason why
                MessageBox.Show("No tags to delete",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Populates the User DataGridView
        /// </summary>
        private void PopulateAdminGrid() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT UserID, Username, Admin " +
                $"FROM Users WHERE UserID!={_userID} AND UserID!=0" +
                "ORDER BY UserID DESC";

            // Create and assign the DataTable with the Password DataTable
            // Assign the DataTable to the DataView
            // Assign the DataGridView with the DataView
            DataTable userTable = Context.GetDataTable(sqlQuery, "Users");
            // Setting the column names
            userTable.Columns[1].ColumnName = "Username";
            userTable.Columns[2].ColumnName = "Admin";

            _dvUsers = new DataView(userTable);
            dgvUsers.DataSource = _dvUsers;

            // Setting column sizes
            dgvUsers.Columns[1].Width = 150;
            dgvUsers.Columns[2].Width = 55;
        }

        /// <summary>
        /// Initiates the Edit Event
        /// </summary>
        private void EditUserEvent() {
            // Create and assign the DataGridView Primary Key
            long userID = long.Parse(dgvUsers[0, dgvUsers.CurrentCell.RowIndex].Value.ToString());

            // Create a new instance of frmPasswordManager (with the Password and User ID)
            // Set the forms parent to this form
            frmUserModifier frm = new frmUserModifier(userID, Location);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateAdminGrid();
            }
        }

        /// <summary>
        /// Provides an input box requesting a password
        /// </summary>
        /// <returns>A bool stating if the password was correct or not</returns>
        private bool RequestPassword(DataRow userData) {
            // Create a bool for the return
            bool returnBool = false;

            if (_mainUserID != 0) {
                // Create a new input dialog
                using (InputDialog inputForm = new InputDialog("Request Password", "Please enter your password", "", true)) {
                    // Create DialogResult and UserInput variables
                    DialogResult inputResult = inputForm.ShowDialog();
                    string userInput = inputForm.InputValue;

                    // Check input was entered
                    // Check if cancelled
                    // Check if empty
                    if (inputResult == DialogResult.OK) {
                        // If password matches return true
                        // Else incorrect password
                        if (HashSalt.CompareInputtoPassword(userInput, userData["PasswordHash"].ToString())) {
                            returnBool = true;
                        } else {
                            MessageBox.Show("Incorrect password",
                                Properties.Settings.Default.ProjectName,
                                MessageBoxButtons.OK);
                        }
                    } else if (inputResult == DialogResult.None) {
                        // No password entered
                        MessageBox.Show("No password entered",
                            Properties.Settings.Default.ProjectName,
                            MessageBoxButtons.OK);
                    }
                }
            } else {
                returnBool = true;
            }

            // Return the bool
            return returnBool;
        }

        #endregion

        #region AccountSettings Events

        // User Settings
        private void BtnDeleteAccount_Click(object sender, EventArgs e) {
            // Check if the user is an admin
            if (_userAdmin) {
                // Check if they are the last admin
                if (GetAllAdmins() < 1) {
                    // Provide reason why
                    MessageBox.Show("You are the last admin. Can not delete your account",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    return;
                }

                // Ask for password
                // If the request returned false, cancel method
                bool success = RequestPassword(_userTable.Rows[0]);
                if (!success) {
                    return;
                }
            }

            // Ask the user if they are sure
            DialogResult box = MessageBox.Show("Are you sure you want to delete your account?",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // If yes, continue on
            if (box == DialogResult.Yes) {
                // Delete the passwords
                DeletePasswords(_userID);

                // Delete user
                // Save DataTable
                // Save Table
                _userTable.Rows[0].Delete();
                _userTable.Rows[0].EndEdit();
                Context.SaveDataBaseTable(_userTable);

                // Logout
                Logout();
            } else {
                // Provide reason why
                MessageBox.Show("Cancelled, account not deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }
        private void BtnDeletePasswords_Click(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Ask the user if they are sure
            DialogResult box = MessageBox.Show("Are you sure you want to delete your passwords?",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // If yes, continue on
            if (box == DialogResult.Yes) {
                // Delete the passwords
                DeletePasswords(_userID);
            } else {
                // Provide reason why
                MessageBox.Show("Cancelled, no passwords deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }
        private void BtnDeleteTags_Click(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Ask the user if they are sure
            DialogResult box = MessageBox.Show("Are you sure you want to delete your tags?",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.YesNo);
            // If yes, continue on
            if (box == DialogResult.Yes) {
                // Delete the passwords
                DeleteTags(_userID);
            } else {
                // Provide reason why
                MessageBox.Show("Cancelled, no tags deleted",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e) {
            // Check the user entered a new password
            if (!string.IsNullOrEmpty(txtChangePassword.Text)) {
                // Compare the passwords
                // If isEqual = true
                bool isEqual = HashSalt.CompareInputtoPassword(txtChangePassword.Text, _userTable.Rows[0]["PasswordHash"].ToString());
                if (isEqual) {
                    // Provide reason why
                    MessageBox.Show($"\"{txtChangePassword.Text}\" is already your password",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    // Reset the users input back to nothing
                    txtChangePassword.Text = "";
                    return;
                }

                // Converting the inputted password to a Hash Salt
                // Reset the users input back to nothing
                string usersPassword = HashSalt.StringtoHashSalt(txtChangePassword.Text);
                txtChangePassword.Text = "";

                // Adding the new password to the User DataTable
                _userTable.Rows[0]["PasswordHash"] = usersPassword;

                // Set the Save Button to enabled
                btnAccountSave.Enabled = true;
            } else {
                // Provide reason why
                MessageBox.Show("Please enter a password",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
            }
        }
        private void CbPasswordRequest_CheckedChanged(object sender, EventArgs e) {
            // Check if the CheckBox doesn't equal the User Setting
            if (cbPasswordRequest.Checked
                != bool.Parse(_userTable.Rows[0]["PasswordRequest"].ToString())) {

                // Assign the Checked result to the DataTable
                _userTable.Rows[0]["PasswordRequest"] = cbPasswordRequest.Checked;

                // Set the Save Button to enabled
                btnAccountSave.Enabled = true;
            }
        }
        private void BtnAccountSave_Click(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Saving User Table
            // Setting the Button Save back to disabled
            Context.SaveDataBaseTable(_userTable);
            btnAccountSave.Enabled = false;

            // Let the user know it was completed
            MessageBox.Show("Account Saved",
                Properties.Settings.Default.ProjectName,
                MessageBoxButtons.OK);
        }

        // Admin Settings
        private void DgvUsers_DoubleClick(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvUsers.CurrentCell == null) {
                return;
            }

            EditUserEvent();
        }
        private void TxtUserSearch_TextChanged(object sender, EventArgs e) {
            // Assign the DataView RowFilter
            _dvUsers.RowFilter = $"Username LIKE '%{txtUserSearch.Text}%'";
        }
        private void BtnEditUser_Click(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvUsers.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            EditUserEvent();
        }
        private void BtnDeleteUser_Click(object sender, EventArgs e) {
            // Ask for password
            // If the request returned false, cancel method
            bool success = RequestPassword(_userTable.Rows[0]);
            if (!success) {
                return;
            }

            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvUsers.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvUsers.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Create and assign the DataGridView Primary Key
            // Create and assign a new SQL Query
            // Create and assign a new User DataTable
            long userID = long.Parse(dgvUsers[0, dgvUsers.CurrentCell.RowIndex].Value.ToString());
            string sqlQuery =
                "SELECT * FROM Users " +
                $"WHERE UserID='{userID}'";
            DataTable userTable = Context.GetDataTable(sqlQuery, "Users");

            // Delete the users passwords
            DeletePasswords(userID);

            // Delete the row from the table
            userTable.Rows[0].Delete();

            // Save the DataTable and Table
            userTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(userTable);

            // Re-populate the grid
            PopulateAdminGrid();
        }

        #endregion

        #region TagsList Helper Methods

        /// <summary>
        /// Initialize the Tag DataTable
        /// </summary>
        /// <param name="tagID"></param>
        private void InitializeTagInATable(long tagID) {
            // Create and assign a new SQL Query
            // Assign the Tag DataTable with the Tag Table
            string sqlQuery =
                "SELECT * FROM Tags " +
                $"WHERE TagID={tagID}";
            _tagTable = Context.GetDataTable(sqlQuery, "Tags");
        }

        /// <summary>
        /// Populates the DataGridView
        /// </summary>
        private void PopulateTagGrid() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT * FROM Tags " +
                $"WHERE UserID={_userID} " +
                "ORDER BY TagID DESC";

            // Create and assign the DataTable with the Password DataTable
            // Assign the DataTable to the DataView
            // Assign the DataGridView with the DataView
            DataTable tagTable = Context.GetDataTable(sqlQuery, "Tags");
            // Setting the column names
            tagTable.Columns[2].ColumnName = "Display";
            tagTable.Columns[3].ColumnName = "Description";

            _dvTag = new DataView(tagTable);
            dgvTags.DataSource = _dvTag;

            // Setting the UserID Column as invisible
            dgvTags.Columns[1].Visible = false;

            // Setting column 
            dgvTags.Columns[2].Width = 185;
            dgvTags.Columns[3].Width = 250;
        }

        /// <summary>
        /// Initiates the Edit Event
        /// </summary>
        private void EditTagEvent() {
            // Create and assign the DataGridView Primary Key
            long tagID = long.Parse(dgvTags[0, dgvTags.CurrentCell.RowIndex].Value.ToString());

            // Create a new instance of frmTagModifier (with the Tag and User ID)
            // Set the forms parent to this form
            frmTagModifier frm = new frmTagModifier(tagID, _userID, Location);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateTagGrid();
            }
        }

        #endregion

        #region TagsList Events

        // TextBox Events
        private void TxtTagsSearch_TextChanged(object sender, EventArgs e) {
            // Assign the DataView RowFilter
            _dvTag.RowFilter = $"Display LIKE '%{txtTagsSearch.Text}%' ";
        }

        // DataGridView Events
        private void DgvTags_DoubleClick(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvTags.CurrentCell == null) {
                return;
            }

            EditTagEvent();
        }
        private void DgvTags_SelectionChanged(object sender, EventArgs e) {
            // Check if a cell has been selected
            // Enable the label
            // Else disable the label
            if (dgvTags.CurrentCell != null) {
                lblTagsWarning.Visible = false;
            } else {
                lblTagsWarning.Visible = true;
            }
        }

        // Button Events
        private void BtnNewTag_Click(object sender, EventArgs e) {
            // Create a new instance of frmTagModifier (with the User ID)
            // Set the forms parent to this form
            frmTagModifier frm = new frmTagModifier(_userID, Location);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateTagGrid();
            }
        }

        private void BtnEditTag_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvTags.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            EditTagEvent();
        }

        private void BtnDeleteTag_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not then stop the method
            if (dgvTags.CurrentCell == null) {
                MessageBox.Show("No cell has been selected",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);
                return;
            }

            // Create and assign the tag id
            long tagID = long.Parse(dgvTags[0, dgvTags.CurrentCell.RowIndex].Value.ToString());
            // Assign the Tag DataTable with Tag Table
            InitializeTagInATable(tagID);

            // Delete the row from the table
            _tagTable.Rows[0].Delete();

            // Save the DataTable and Table
            _tagTable.Rows[0].EndEdit();
            Context.SaveDataBaseTable(_tagTable);

            // Re-populate the grid
            PopulateTagGrid();
        }

        #endregion
    }
}
