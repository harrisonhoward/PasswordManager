namespace PasswordManager {
    partial class frmPasswordMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordMain));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAccount = new System.Windows.Forms.ToolStripButton();
            this.tssAccPassListSep = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPasswordList = new System.Windows.Forms.ToolStripButton();
            this.tssPassListTagsList = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTagsList = new System.Windows.Forms.ToolStripButton();
            this.tsdAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDividier2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panPasswordList = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboTags = new System.Windows.Forms.ComboBox();
            this.btnPasswordImport = new System.Windows.Forms.Button();
            this.btnPasswordExport = new System.Windows.Forms.Button();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.txtPasswordSearch = new System.Windows.Forms.TextBox();
            this.lblPasswordSearch = new System.Windows.Forms.Label();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.panAccountSettings = new System.Windows.Forms.Panel();
            this.gbAdminSettings = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbUserSettings = new System.Windows.Forms.GroupBox();
            this.gbAccountDanger = new System.Windows.Forms.GroupBox();
            this.btnDeleteTags = new System.Windows.Forms.Button();
            this.btnDeletePasswords = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAccountSave = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.panTagsList = new System.Windows.Forms.Panel();
            this.lblTagsWarning = new System.Windows.Forms.Label();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnEditTag = new System.Windows.Forms.Button();
            this.btnNewTag = new System.Windows.Forms.Button();
            this.txtTagsSearch = new System.Windows.Forms.TextBox();
            this.lblTagsSearch = new System.Windows.Forms.Label();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.cbPasswordRequest = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            this.panPasswordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.panAccountSettings.SuspendLayout();
            this.gbAdminSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbUserSettings.SuspendLayout();
            this.gbAccountDanger.SuspendLayout();
            this.panTagsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAccount,
            this.tssAccPassListSep,
            this.tsbPasswordList,
            this.tssPassListTagsList,
            this.tsbTagsList,
            this.tsdAccount});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsMain_ItemClicked);
            // 
            // tsbAccount
            // 
            this.tsbAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccount.Image")));
            this.tsbAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccount.Name = "tsbAccount";
            this.tsbAccount.Size = new System.Drawing.Size(101, 22);
            this.tsbAccount.Text = "Account Settings";
            this.tsbAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbAccount.ToolTipText = "Change your account settings";
            // 
            // tssAccPassListSep
            // 
            this.tssAccPassListSep.Name = "tssAccPassListSep";
            this.tssAccPassListSep.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPasswordList
            // 
            this.tsbPasswordList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPasswordList.Image = ((System.Drawing.Image)(resources.GetObject("tsbPasswordList.Image")));
            this.tsbPasswordList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPasswordList.Name = "tsbPasswordList";
            this.tsbPasswordList.Size = new System.Drawing.Size(82, 22);
            this.tsbPasswordList.Text = "Password List";
            this.tsbPasswordList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbPasswordList.ToolTipText = "Display all your passwords";
            // 
            // tssPassListTagsList
            // 
            this.tssPassListTagsList.Name = "tssPassListTagsList";
            this.tssPassListTagsList.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTagsList
            // 
            this.tsbTagsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTagsList.Image = ((System.Drawing.Image)(resources.GetObject("tsbTagsList.Image")));
            this.tsbTagsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTagsList.Name = "tsbTagsList";
            this.tsbTagsList.Size = new System.Drawing.Size(55, 22);
            this.tsbTagsList.Text = "Tags List";
            this.tsbTagsList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // tsdAccount
            // 
            this.tsdAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsdAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdiLogout});
            this.tsdAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsdAccount.Image")));
            this.tsdAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAccount.Name = "tsdAccount";
            this.tsdAccount.Size = new System.Drawing.Size(13, 22);
            this.tsdAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsdAccount.ToolTipText = "Account Drop Down List";
            this.tsdAccount.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsdAccount_DropDownItemClicked);
            // 
            // tsdiLogout
            // 
            this.tsdiLogout.Name = "tsdiLogout";
            this.tsdiLogout.Size = new System.Drawing.Size(112, 22);
            this.tsdiLogout.Text = "Logout";
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-9, 25);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(820, 2);
            this.lblDivider.TabIndex = 1;
            // 
            // lblDividier2
            // 
            this.lblDividier2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDividier2.Location = new System.Drawing.Point(-9, 417);
            this.lblDividier2.Name = "lblDividier2";
            this.lblDividier2.Size = new System.Drawing.Size(820, 2);
            this.lblDividier2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(714, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panPasswordList
            // 
            this.panPasswordList.Controls.Add(this.lblFilter);
            this.panPasswordList.Controls.Add(this.cboTags);
            this.panPasswordList.Controls.Add(this.btnPasswordImport);
            this.panPasswordList.Controls.Add(this.btnPasswordExport);
            this.panPasswordList.Controls.Add(this.lblPasswordWarning);
            this.panPasswordList.Controls.Add(this.btnDeletePassword);
            this.panPasswordList.Controls.Add(this.btnEditPassword);
            this.panPasswordList.Controls.Add(this.btnNewPassword);
            this.panPasswordList.Controls.Add(this.txtPasswordSearch);
            this.panPasswordList.Controls.Add(this.lblPasswordSearch);
            this.panPasswordList.Controls.Add(this.dgvPasswords);
            this.panPasswordList.Location = new System.Drawing.Point(0, 27);
            this.panPasswordList.Name = "panPasswordList";
            this.panPasswordList.Size = new System.Drawing.Size(800, 390);
            this.panPasswordList.TabIndex = 6;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(368, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(59, 16);
            this.lblFilter.TabIndex = 16;
            this.lblFilter.Text = "Filter by:";
            // 
            // cboTags
            // 
            this.cboTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.63F);
            this.cboTags.FormattingEnabled = true;
            this.cboTags.Items.AddRange(new object[] {
            "None"});
            this.cboTags.Location = new System.Drawing.Point(433, 15);
            this.cboTags.Name = "cboTags";
            this.cboTags.Size = new System.Drawing.Size(181, 23);
            this.cboTags.TabIndex = 15;
            this.cboTags.SelectedIndexChanged += new System.EventHandler(this.CboTags_SelectedIndexChanged);
            // 
            // btnPasswordImport
            // 
            this.btnPasswordImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordImport.Location = new System.Drawing.Point(626, 345);
            this.btnPasswordImport.Name = "btnPasswordImport";
            this.btnPasswordImport.Size = new System.Drawing.Size(78, 28);
            this.btnPasswordImport.TabIndex = 14;
            this.btnPasswordImport.Text = "Import";
            this.btnPasswordImport.UseVisualStyleBackColor = true;
            this.btnPasswordImport.Click += new System.EventHandler(this.BtnPasswordImport_Click);
            // 
            // btnPasswordExport
            // 
            this.btnPasswordExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordExport.Location = new System.Drawing.Point(710, 345);
            this.btnPasswordExport.Name = "btnPasswordExport";
            this.btnPasswordExport.Size = new System.Drawing.Size(78, 28);
            this.btnPasswordExport.TabIndex = 4;
            this.btnPasswordExport.Text = "Export";
            this.btnPasswordExport.UseVisualStyleBackColor = true;
            this.btnPasswordExport.Click += new System.EventHandler(this.BtnPasswordExport_Click);
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordWarning.Location = new System.Drawing.Point(634, 22);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(85, 16);
            this.lblPasswordWarning.TabIndex = 13;
            this.lblPasswordWarning.Text = "Select a cell";
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePassword.Location = new System.Drawing.Point(620, 109);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(120, 28);
            this.btnDeletePassword.TabIndex = 3;
            this.btnDeletePassword.Text = "Delete Password";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            this.btnDeletePassword.Click += new System.EventHandler(this.BtnDeletePassword_Click);
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.Location = new System.Drawing.Point(620, 75);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(120, 28);
            this.btnEditPassword.TabIndex = 2;
            this.btnEditPassword.Text = "Edit Password";
            this.btnEditPassword.UseVisualStyleBackColor = true;
            this.btnEditPassword.Click += new System.EventHandler(this.BtnEditPassword_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Location = new System.Drawing.Point(620, 41);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(120, 28);
            this.btnNewPassword.TabIndex = 1;
            this.btnNewPassword.Text = "New Password";
            this.btnNewPassword.UseVisualStyleBackColor = true;
            this.btnNewPassword.Click += new System.EventHandler(this.BtnNewPassword_Click);
            // 
            // txtPasswordSearch
            // 
            this.txtPasswordSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSearch.Location = new System.Drawing.Point(71, 16);
            this.txtPasswordSearch.MaxLength = 60;
            this.txtPasswordSearch.Name = "txtPasswordSearch";
            this.txtPasswordSearch.Size = new System.Drawing.Size(291, 22);
            this.txtPasswordSearch.TabIndex = 0;
            this.txtPasswordSearch.TextChanged += new System.EventHandler(this.TxtPasswordSearch_TextChanged);
            // 
            // lblPasswordSearch
            // 
            this.lblPasswordSearch.AutoSize = true;
            this.lblPasswordSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSearch.Location = new System.Drawing.Point(12, 18);
            this.lblPasswordSearch.Name = "lblPasswordSearch";
            this.lblPasswordSearch.Size = new System.Drawing.Size(53, 16);
            this.lblPasswordSearch.TabIndex = 8;
            this.lblPasswordSearch.Text = "Search:";
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToAddRows = false;
            this.dgvPasswords.AllowUserToDeleteRows = false;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Location = new System.Drawing.Point(14, 41);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            this.dgvPasswords.RowHeadersWidth = 20;
            this.dgvPasswords.Size = new System.Drawing.Size(600, 332);
            this.dgvPasswords.TabIndex = 7;
            this.dgvPasswords.SelectionChanged += new System.EventHandler(this.DgvPasswords_SelectionChanged);
            this.dgvPasswords.DoubleClick += new System.EventHandler(this.DgvPasswords_DoubleClick);
            // 
            // panAccountSettings
            // 
            this.panAccountSettings.Controls.Add(this.gbAdminSettings);
            this.panAccountSettings.Controls.Add(this.gbUserSettings);
            this.panAccountSettings.Location = new System.Drawing.Point(0, 27);
            this.panAccountSettings.Name = "panAccountSettings";
            this.panAccountSettings.Size = new System.Drawing.Size(800, 390);
            this.panAccountSettings.TabIndex = 14;
            // 
            // gbAdminSettings
            // 
            this.gbAdminSettings.Controls.Add(this.btnDeleteUser);
            this.gbAdminSettings.Controls.Add(this.txtUserSearch);
            this.gbAdminSettings.Controls.Add(this.lblUserSearch);
            this.gbAdminSettings.Controls.Add(this.btnEditUser);
            this.gbAdminSettings.Controls.Add(this.dgvUsers);
            this.gbAdminSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdminSettings.Location = new System.Drawing.Point(400, 16);
            this.gbAdminSettings.Name = "gbAdminSettings";
            this.gbAdminSettings.Size = new System.Drawing.Size(382, 357);
            this.gbAdminSettings.TabIndex = 1;
            this.gbAdminSettings.TabStop = false;
            this.gbAdminSettings.Text = "Admin Settings";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(99, 323);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(89, 28);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(65, 34);
            this.txtUserSearch.MaxLength = 60;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(222, 22);
            this.txtUserSearch.TabIndex = 5;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.TxtUserSearch_TextChanged);
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSearch.Location = new System.Drawing.Point(6, 37);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(53, 16);
            this.lblUserSearch.TabIndex = 11;
            this.lblUserSearch.Text = "Search:";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(9, 323);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(84, 28);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 59);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 60;
            this.dgvUsers.Size = new System.Drawing.Size(370, 258);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.DoubleClick += new System.EventHandler(this.DgvUsers_DoubleClick);
            // 
            // gbUserSettings
            // 
            this.gbUserSettings.Controls.Add(this.label1);
            this.gbUserSettings.Controls.Add(this.cbPasswordRequest);
            this.gbUserSettings.Controls.Add(this.gbAccountDanger);
            this.gbUserSettings.Controls.Add(this.btnAccountSave);
            this.gbUserSettings.Controls.Add(this.btnChangePassword);
            this.gbUserSettings.Controls.Add(this.txtChangePassword);
            this.gbUserSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserSettings.Location = new System.Drawing.Point(12, 16);
            this.gbUserSettings.Name = "gbUserSettings";
            this.gbUserSettings.Size = new System.Drawing.Size(382, 357);
            this.gbUserSettings.TabIndex = 0;
            this.gbUserSettings.TabStop = false;
            this.gbUserSettings.Text = "User Settings";
            // 
            // gbAccountDanger
            // 
            this.gbAccountDanger.Controls.Add(this.btnDeleteTags);
            this.gbAccountDanger.Controls.Add(this.btnDeletePasswords);
            this.gbAccountDanger.Controls.Add(this.btnDeleteAccount);
            this.gbAccountDanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbAccountDanger.Location = new System.Drawing.Point(6, 219);
            this.gbAccountDanger.Name = "gbAccountDanger";
            this.gbAccountDanger.Size = new System.Drawing.Size(200, 132);
            this.gbAccountDanger.TabIndex = 15;
            this.gbAccountDanger.TabStop = false;
            this.gbAccountDanger.Text = "Danger Zone";
            // 
            // btnDeleteTags
            // 
            this.btnDeleteTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTags.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTags.Location = new System.Drawing.Point(33, 92);
            this.btnDeleteTags.Name = "btnDeleteTags";
            this.btnDeleteTags.Size = new System.Drawing.Size(132, 29);
            this.btnDeleteTags.TabIndex = 4;
            this.btnDeleteTags.Text = "Delete Tags";
            this.btnDeleteTags.UseVisualStyleBackColor = true;
            this.btnDeleteTags.Click += new System.EventHandler(this.BtnDeleteTags_Click);
            // 
            // btnDeletePasswords
            // 
            this.btnDeletePasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePasswords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletePasswords.Location = new System.Drawing.Point(33, 57);
            this.btnDeletePasswords.Name = "btnDeletePasswords";
            this.btnDeletePasswords.Size = new System.Drawing.Size(132, 29);
            this.btnDeletePasswords.TabIndex = 3;
            this.btnDeletePasswords.Text = "Delete Passwords";
            this.btnDeletePasswords.UseVisualStyleBackColor = true;
            this.btnDeletePasswords.Click += new System.EventHandler(this.BtnDeletePasswords_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(33, 22);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(132, 29);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnAccountSave
            // 
            this.btnAccountSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSave.Location = new System.Drawing.Point(292, 323);
            this.btnAccountSave.Name = "btnAccountSave";
            this.btnAccountSave.Size = new System.Drawing.Size(84, 28);
            this.btnAccountSave.TabIndex = 4;
            this.btnAccountSave.Text = "Save";
            this.btnAccountSave.UseVisualStyleBackColor = true;
            this.btnAccountSave.Click += new System.EventHandler(this.BtnAccountSave_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(167, 27);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 29);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword.Location = new System.Drawing.Point(6, 31);
            this.txtChangePassword.MaxLength = 60;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(155, 22);
            this.txtChangePassword.TabIndex = 0;
            // 
            // panTagsList
            // 
            this.panTagsList.Controls.Add(this.lblTagsWarning);
            this.panTagsList.Controls.Add(this.btnDeleteTag);
            this.panTagsList.Controls.Add(this.btnEditTag);
            this.panTagsList.Controls.Add(this.btnNewTag);
            this.panTagsList.Controls.Add(this.txtTagsSearch);
            this.panTagsList.Controls.Add(this.lblTagsSearch);
            this.panTagsList.Controls.Add(this.dgvTags);
            this.panTagsList.Location = new System.Drawing.Point(0, 27);
            this.panTagsList.Name = "panTagsList";
            this.panTagsList.Size = new System.Drawing.Size(800, 390);
            this.panTagsList.TabIndex = 15;
            // 
            // lblTagsWarning
            // 
            this.lblTagsWarning.AutoSize = true;
            this.lblTagsWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsWarning.Location = new System.Drawing.Point(642, 18);
            this.lblTagsWarning.Name = "lblTagsWarning";
            this.lblTagsWarning.Size = new System.Drawing.Size(85, 16);
            this.lblTagsWarning.TabIndex = 20;
            this.lblTagsWarning.Text = "Select a cell";
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTag.Location = new System.Drawing.Point(637, 106);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(99, 28);
            this.btnDeleteTag.TabIndex = 17;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Click += new System.EventHandler(this.BtnDeleteTag_Click);
            // 
            // btnEditTag
            // 
            this.btnEditTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTag.Location = new System.Drawing.Point(637, 72);
            this.btnEditTag.Name = "btnEditTag";
            this.btnEditTag.Size = new System.Drawing.Size(99, 28);
            this.btnEditTag.TabIndex = 16;
            this.btnEditTag.Text = "Edit Tag";
            this.btnEditTag.UseVisualStyleBackColor = true;
            this.btnEditTag.Click += new System.EventHandler(this.BtnEditTag_Click);
            // 
            // btnNewTag
            // 
            this.btnNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTag.Location = new System.Drawing.Point(637, 38);
            this.btnNewTag.Name = "btnNewTag";
            this.btnNewTag.Size = new System.Drawing.Size(99, 28);
            this.btnNewTag.TabIndex = 15;
            this.btnNewTag.Text = "New Tag";
            this.btnNewTag.UseVisualStyleBackColor = true;
            this.btnNewTag.Click += new System.EventHandler(this.BtnNewTag_Click);
            // 
            // txtTagsSearch
            // 
            this.txtTagsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagsSearch.Location = new System.Drawing.Point(77, 14);
            this.txtTagsSearch.MaxLength = 60;
            this.txtTagsSearch.Name = "txtTagsSearch";
            this.txtTagsSearch.Size = new System.Drawing.Size(543, 22);
            this.txtTagsSearch.TabIndex = 14;
            this.txtTagsSearch.TextChanged += new System.EventHandler(this.TxtTagsSearch_TextChanged);
            // 
            // lblTagsSearch
            // 
            this.lblTagsSearch.AutoSize = true;
            this.lblTagsSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsSearch.Location = new System.Drawing.Point(18, 16);
            this.lblTagsSearch.Name = "lblTagsSearch";
            this.lblTagsSearch.Size = new System.Drawing.Size(53, 16);
            this.lblTagsSearch.TabIndex = 19;
            this.lblTagsSearch.Text = "Search:";
            // 
            // dgvTags
            // 
            this.dgvTags.AllowUserToAddRows = false;
            this.dgvTags.AllowUserToDeleteRows = false;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Location = new System.Drawing.Point(20, 39);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.ReadOnly = true;
            this.dgvTags.RowHeadersWidth = 60;
            this.dgvTags.Size = new System.Drawing.Size(600, 332);
            this.dgvTags.TabIndex = 18;
            this.dgvTags.SelectionChanged += new System.EventHandler(this.DgvTags_SelectionChanged);
            this.dgvTags.DoubleClick += new System.EventHandler(this.DgvTags_DoubleClick);
            // 
            // cbPasswordRequest
            // 
            this.cbPasswordRequest.AutoSize = true;
            this.cbPasswordRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordRequest.Location = new System.Drawing.Point(148, 64);
            this.cbPasswordRequest.Name = "cbPasswordRequest";
            this.cbPasswordRequest.Size = new System.Drawing.Size(136, 20);
            this.cbPasswordRequest.TabIndex = 2;
            this.cbPasswordRequest.Text = " Request Password";
            this.cbPasswordRequest.UseVisualStyleBackColor = true;
            this.cbPasswordRequest.CheckedChanged += new System.EventHandler(this.CbPasswordRequest_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Upon editing a password";
            // 
            // frmPasswordMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panAccountSettings);
            this.Controls.Add(this.panPasswordList);
            this.Controls.Add(this.panTagsList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDividier2);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPasswordMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.panPasswordList.ResumeLayout(false);
            this.panPasswordList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            this.panAccountSettings.ResumeLayout(false);
            this.gbAdminSettings.ResumeLayout(false);
            this.gbAdminSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbUserSettings.ResumeLayout(false);
            this.gbUserSettings.PerformLayout();
            this.gbAccountDanger.ResumeLayout(false);
            this.panTagsList.ResumeLayout(false);
            this.panTagsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbPasswordList;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblDividier2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panPasswordList;
        private System.Windows.Forms.TextBox txtPasswordSearch;
        private System.Windows.Forms.Label lblPasswordSearch;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.Button btnDeletePassword;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.ToolStripDropDownButton tsdAccount;
        private System.Windows.Forms.ToolStripMenuItem tsdiLogout;
        private System.Windows.Forms.ToolStripButton tsbAccount;
        private System.Windows.Forms.ToolStripSeparator tssAccPassListSep;
        private System.Windows.Forms.Panel panAccountSettings;
        private System.Windows.Forms.GroupBox gbUserSettings;
        private System.Windows.Forms.GroupBox gbAdminSettings;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox gbAccountDanger;
        private System.Windows.Forms.Button btnDeletePasswords;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAccountSave;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnPasswordExport;
        private System.Windows.Forms.Button btnPasswordImport;
        private System.Windows.Forms.ToolStripSeparator tssPassListTagsList;
        private System.Windows.Forms.ToolStripButton tsbTagsList;
        private System.Windows.Forms.Panel panTagsList;
        private System.Windows.Forms.Label lblTagsWarning;
        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.Button btnEditTag;
        private System.Windows.Forms.Button btnNewTag;
        private System.Windows.Forms.TextBox txtTagsSearch;
        private System.Windows.Forms.Label lblTagsSearch;
        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.Button btnDeleteTags;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboTags;
        private System.Windows.Forms.CheckBox cbPasswordRequest;
        private System.Windows.Forms.Label label1;
    }
}