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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAccount = new System.Windows.Forms.ToolStripButton();
            this.tsbPasswordList = new System.Windows.Forms.ToolStripButton();
            this.tsbTagsList = new System.Windows.Forms.ToolStripButton();
            this.tsdAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDividier2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panPasswordList = new System.Windows.Forms.Panel();
            this.lblPasswordsCount = new System.Windows.Forms.Label();
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
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbUserSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPasswordRequest = new System.Windows.Forms.CheckBox();
            this.gbAccountDanger = new System.Windows.Forms.GroupBox();
            this.btnDeleteTags = new System.Windows.Forms.Button();
            this.btnDeletePasswords = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAccountSave = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.panTagsList = new System.Windows.Forms.Panel();
            this.lblTagsCount = new System.Windows.Forms.Label();
            this.lblTagsWarning = new System.Windows.Forms.Label();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnEditTag = new System.Windows.Forms.Button();
            this.btnNewTag = new System.Windows.Forms.Button();
            this.txtTagsSearch = new System.Windows.Forms.TextBox();
            this.lblTagsSearch = new System.Windows.Forms.Label();
            this.dgvTags = new System.Windows.Forms.DataGridView();
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
            this.tsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAccount,
            this.tsbPasswordList,
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
            this.tsbAccount.ForeColor = System.Drawing.Color.DarkGray;
            this.tsbAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccount.Image")));
            this.tsbAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccount.Name = "tsbAccount";
            this.tsbAccount.Size = new System.Drawing.Size(101, 22);
            this.tsbAccount.Text = "Account Settings";
            this.tsbAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbAccount.ToolTipText = "Change your account settings";
            this.tsbAccount.MouseEnter += new System.EventHandler(this.TSItem_MouseEnter);
            this.tsbAccount.MouseLeave += new System.EventHandler(this.TSItem_MouseLeave);
            // 
            // tsbPasswordList
            // 
            this.tsbPasswordList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPasswordList.ForeColor = System.Drawing.Color.DarkGray;
            this.tsbPasswordList.Image = ((System.Drawing.Image)(resources.GetObject("tsbPasswordList.Image")));
            this.tsbPasswordList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPasswordList.Name = "tsbPasswordList";
            this.tsbPasswordList.Size = new System.Drawing.Size(82, 22);
            this.tsbPasswordList.Text = "Password List";
            this.tsbPasswordList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbPasswordList.ToolTipText = "Display all your passwords";
            this.tsbPasswordList.MouseEnter += new System.EventHandler(this.TSItem_MouseEnter);
            this.tsbPasswordList.MouseLeave += new System.EventHandler(this.TSItem_MouseLeave);
            // 
            // tsbTagsList
            // 
            this.tsbTagsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tsbTagsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTagsList.ForeColor = System.Drawing.Color.DarkGray;
            this.tsbTagsList.Image = ((System.Drawing.Image)(resources.GetObject("tsbTagsList.Image")));
            this.tsbTagsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTagsList.Name = "tsbTagsList";
            this.tsbTagsList.Size = new System.Drawing.Size(55, 22);
            this.tsbTagsList.Text = "Tags List";
            this.tsbTagsList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbTagsList.ToolTipText = "Display all your tags";
            this.tsbTagsList.MouseEnter += new System.EventHandler(this.TSItem_MouseEnter);
            this.tsbTagsList.MouseLeave += new System.EventHandler(this.TSItem_MouseLeave);
            // 
            // tsdAccount
            // 
            this.tsdAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsdAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tsdAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdiLogout});
            this.tsdAccount.ForeColor = System.Drawing.Color.DarkGray;
            this.tsdAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsdAccount.Image")));
            this.tsdAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAccount.Name = "tsdAccount";
            this.tsdAccount.Size = new System.Drawing.Size(13, 22);
            this.tsdAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsdAccount.ToolTipText = "Account Drop Down List";
            this.tsdAccount.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsdAccount_DropDownItemClicked);
            this.tsdAccount.MouseEnter += new System.EventHandler(this.TSItem_MouseEnter);
            this.tsdAccount.MouseLeave += new System.EventHandler(this.TSItem_MouseLeave);
            // 
            // tsdiLogout
            // 
            this.tsdiLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tsdiLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsdiLogout.Name = "tsdiLogout";
            this.tsdiLogout.Size = new System.Drawing.Size(180, 22);
            this.tsdiLogout.Text = "Logout";
            this.tsdiLogout.MouseEnter += new System.EventHandler(this.TSItem_MouseEnter);
            this.tsdiLogout.MouseLeave += new System.EventHandler(this.TSItem_MouseLeave);
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
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(714, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panPasswordList
            // 
            this.panPasswordList.Controls.Add(this.lblPasswordsCount);
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
            // lblPasswordsCount
            // 
            this.lblPasswordsCount.AutoSize = true;
            this.lblPasswordsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordsCount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPasswordsCount.Location = new System.Drawing.Point(623, 357);
            this.lblPasswordsCount.Name = "lblPasswordsCount";
            this.lblPasswordsCount.Size = new System.Drawing.Size(100, 16);
            this.lblPasswordsCount.TabIndex = 17;
            this.lblPasswordsCount.Text = "Password Count";
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFilter.Location = new System.Drawing.Point(365, 16);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 22);
            this.lblFilter.TabIndex = 16;
            this.lblFilter.Text = "Filter by:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTags
            // 
            this.cboTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTags.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboTags.FormattingEnabled = true;
            this.cboTags.Location = new System.Drawing.Point(433, 16);
            this.cboTags.Name = "cboTags";
            this.cboTags.Size = new System.Drawing.Size(181, 21);
            this.cboTags.TabIndex = 15;
            this.cboTags.SelectedIndexChanged += new System.EventHandler(this.CboTags_SelectedIndexChanged);
            // 
            // btnPasswordImport
            // 
            this.btnPasswordImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPasswordImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPasswordImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPasswordImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPasswordImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordImport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPasswordImport.Location = new System.Drawing.Point(626, 323);
            this.btnPasswordImport.Name = "btnPasswordImport";
            this.btnPasswordImport.Size = new System.Drawing.Size(78, 28);
            this.btnPasswordImport.TabIndex = 14;
            this.btnPasswordImport.Text = "Import";
            this.btnPasswordImport.UseVisualStyleBackColor = false;
            this.btnPasswordImport.Click += new System.EventHandler(this.BtnPasswordImport_Click);
            // 
            // btnPasswordExport
            // 
            this.btnPasswordExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPasswordExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPasswordExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPasswordExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPasswordExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordExport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPasswordExport.Location = new System.Drawing.Point(710, 323);
            this.btnPasswordExport.Name = "btnPasswordExport";
            this.btnPasswordExport.Size = new System.Drawing.Size(78, 28);
            this.btnPasswordExport.TabIndex = 4;
            this.btnPasswordExport.Text = "Export";
            this.btnPasswordExport.UseVisualStyleBackColor = false;
            this.btnPasswordExport.Click += new System.EventHandler(this.BtnPasswordExport_Click);
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPasswordWarning.Location = new System.Drawing.Point(634, 22);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(85, 16);
            this.lblPasswordWarning.TabIndex = 13;
            this.lblPasswordWarning.Text = "Select a cell";
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeletePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeletePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeletePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeletePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePassword.Location = new System.Drawing.Point(620, 109);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(120, 28);
            this.btnDeletePassword.TabIndex = 3;
            this.btnDeletePassword.Text = "Delete Password";
            this.btnDeletePassword.UseVisualStyleBackColor = false;
            this.btnDeletePassword.Click += new System.EventHandler(this.BtnDeletePassword_Click);
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPassword.Location = new System.Drawing.Point(620, 75);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(120, 28);
            this.btnEditPassword.TabIndex = 2;
            this.btnEditPassword.Text = "Edit Password";
            this.btnEditPassword.UseVisualStyleBackColor = false;
            this.btnEditPassword.Click += new System.EventHandler(this.BtnEditPassword_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewPassword.Location = new System.Drawing.Point(620, 41);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(120, 28);
            this.btnNewPassword.TabIndex = 1;
            this.btnNewPassword.Text = "New Password";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.BtnNewPassword_Click);
            // 
            // txtPasswordSearch
            // 
            this.txtPasswordSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordSearch.Location = new System.Drawing.Point(71, 16);
            this.txtPasswordSearch.MaxLength = 60;
            this.txtPasswordSearch.Name = "txtPasswordSearch";
            this.txtPasswordSearch.Size = new System.Drawing.Size(291, 22);
            this.txtPasswordSearch.TabIndex = 0;
            this.txtPasswordSearch.TextChanged += new System.EventHandler(this.TxtPasswordSearch_TextChanged);
            this.txtPasswordSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent_KeyDown);
            // 
            // lblPasswordSearch
            // 
            this.lblPasswordSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPasswordSearch.Location = new System.Drawing.Point(15, 16);
            this.lblPasswordSearch.Name = "lblPasswordSearch";
            this.lblPasswordSearch.Size = new System.Drawing.Size(63, 22);
            this.lblPasswordSearch.TabIndex = 8;
            this.lblPasswordSearch.Text = "Search:";
            this.lblPasswordSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToAddRows = false;
            this.dgvPasswords.AllowUserToDeleteRows = false;
            this.dgvPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPasswords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasswords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPasswords.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPasswords.EnableHeadersVisualStyles = false;
            this.dgvPasswords.Location = new System.Drawing.Point(14, 41);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasswords.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
            this.gbAdminSettings.Controls.Add(this.lblUsersCount);
            this.gbAdminSettings.Controls.Add(this.btnSignIn);
            this.gbAdminSettings.Controls.Add(this.btnDeleteUser);
            this.gbAdminSettings.Controls.Add(this.txtUserSearch);
            this.gbAdminSettings.Controls.Add(this.lblUserSearch);
            this.gbAdminSettings.Controls.Add(this.btnEditUser);
            this.gbAdminSettings.Controls.Add(this.dgvUsers);
            this.gbAdminSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdminSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.gbAdminSettings.Location = new System.Drawing.Point(400, 16);
            this.gbAdminSettings.Name = "gbAdminSettings";
            this.gbAdminSettings.Size = new System.Drawing.Size(382, 357);
            this.gbAdminSettings.TabIndex = 1;
            this.gbAdminSettings.TabStop = false;
            this.gbAdminSettings.Text = "Admin Settings";
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.Location = new System.Drawing.Point(284, 335);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(98, 16);
            this.lblUsersCount.TabIndex = 18;
            this.lblUsersCount.Text = "User Count";
            this.lblUsersCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.Location = new System.Drawing.Point(194, 323);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(84, 28);
            this.btnSignIn.TabIndex = 17;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Visible = false;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteUser.Location = new System.Drawing.Point(99, 323);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(89, 28);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserSearch.Location = new System.Drawing.Point(65, 34);
            this.txtUserSearch.MaxLength = 60;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(222, 22);
            this.txtUserSearch.TabIndex = 5;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.TxtUserSearch_TextChanged);
            this.txtUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent_KeyDown);
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUserSearch.Location = new System.Drawing.Point(7, 34);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(59, 22);
            this.lblUserSearch.TabIndex = 11;
            this.lblUserSearch.Text = "Search:";
            this.lblUserSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditUser.Location = new System.Drawing.Point(9, 323);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(84, 28);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(6, 59);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
            this.gbUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUserSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.gbUserSettings.Location = new System.Drawing.Point(12, 16);
            this.gbUserSettings.Name = "gbUserSettings";
            this.gbUserSettings.Size = new System.Drawing.Size(382, 357);
            this.gbUserSettings.TabIndex = 0;
            this.gbUserSettings.TabStop = false;
            this.gbUserSettings.Text = "User Settings";
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
            this.btnDeleteTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteTags.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteTags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTags.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTags.Location = new System.Drawing.Point(33, 92);
            this.btnDeleteTags.Name = "btnDeleteTags";
            this.btnDeleteTags.Size = new System.Drawing.Size(132, 29);
            this.btnDeleteTags.TabIndex = 4;
            this.btnDeleteTags.Text = "Delete Tags";
            this.btnDeleteTags.UseVisualStyleBackColor = false;
            this.btnDeleteTags.Click += new System.EventHandler(this.BtnDeleteTags_Click);
            // 
            // btnDeletePasswords
            // 
            this.btnDeletePasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeletePasswords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeletePasswords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeletePasswords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeletePasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePasswords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePasswords.Location = new System.Drawing.Point(33, 57);
            this.btnDeletePasswords.Name = "btnDeletePasswords";
            this.btnDeletePasswords.Size = new System.Drawing.Size(132, 29);
            this.btnDeletePasswords.TabIndex = 3;
            this.btnDeletePasswords.Text = "Delete Passwords";
            this.btnDeletePasswords.UseVisualStyleBackColor = false;
            this.btnDeletePasswords.Click += new System.EventHandler(this.BtnDeletePasswords_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAccount.Location = new System.Drawing.Point(33, 22);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(132, 29);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnAccountSave
            // 
            this.btnAccountSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAccountSave.Enabled = false;
            this.btnAccountSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAccountSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccountSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAccountSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccountSave.Location = new System.Drawing.Point(292, 323);
            this.btnAccountSave.Name = "btnAccountSave";
            this.btnAccountSave.Size = new System.Drawing.Size(84, 28);
            this.btnAccountSave.TabIndex = 4;
            this.btnAccountSave.Text = "Save";
            this.btnAccountSave.UseVisualStyleBackColor = false;
            this.btnAccountSave.Click += new System.EventHandler(this.BtnAccountSave_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePassword.Location = new System.Drawing.Point(167, 27);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 29);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtChangePassword.Location = new System.Drawing.Point(6, 31);
            this.txtChangePassword.MaxLength = 60;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(155, 22);
            this.txtChangePassword.TabIndex = 0;
            this.txtChangePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent_KeyDown);
            // 
            // panTagsList
            // 
            this.panTagsList.Controls.Add(this.lblTagsCount);
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
            // lblTagsCount
            // 
            this.lblTagsCount.AutoSize = true;
            this.lblTagsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsCount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTagsCount.Location = new System.Drawing.Point(623, 354);
            this.lblTagsCount.Name = "lblTagsCount";
            this.lblTagsCount.Size = new System.Drawing.Size(67, 16);
            this.lblTagsCount.TabIndex = 21;
            this.lblTagsCount.Text = "Tag Count";
            // 
            // lblTagsWarning
            // 
            this.lblTagsWarning.AutoSize = true;
            this.lblTagsWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsWarning.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTagsWarning.Location = new System.Drawing.Point(642, 18);
            this.lblTagsWarning.Name = "lblTagsWarning";
            this.lblTagsWarning.Size = new System.Drawing.Size(85, 16);
            this.lblTagsWarning.TabIndex = 20;
            this.lblTagsWarning.Text = "Select a cell";
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTag.Location = new System.Drawing.Point(637, 106);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(99, 28);
            this.btnDeleteTag.TabIndex = 17;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = false;
            this.btnDeleteTag.Click += new System.EventHandler(this.BtnDeleteTag_Click);
            // 
            // btnEditTag
            // 
            this.btnEditTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditTag.Location = new System.Drawing.Point(637, 72);
            this.btnEditTag.Name = "btnEditTag";
            this.btnEditTag.Size = new System.Drawing.Size(99, 28);
            this.btnEditTag.TabIndex = 16;
            this.btnEditTag.Text = "Edit Tag";
            this.btnEditTag.UseVisualStyleBackColor = false;
            this.btnEditTag.Click += new System.EventHandler(this.BtnEditTag_Click);
            // 
            // btnNewTag
            // 
            this.btnNewTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNewTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNewTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNewTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNewTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewTag.Location = new System.Drawing.Point(637, 38);
            this.btnNewTag.Name = "btnNewTag";
            this.btnNewTag.Size = new System.Drawing.Size(99, 28);
            this.btnNewTag.TabIndex = 15;
            this.btnNewTag.Text = "New Tag";
            this.btnNewTag.UseVisualStyleBackColor = false;
            this.btnNewTag.Click += new System.EventHandler(this.BtnNewTag_Click);
            // 
            // txtTagsSearch
            // 
            this.txtTagsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTagsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagsSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTagsSearch.Location = new System.Drawing.Point(77, 14);
            this.txtTagsSearch.MaxLength = 60;
            this.txtTagsSearch.Name = "txtTagsSearch";
            this.txtTagsSearch.Size = new System.Drawing.Size(543, 22);
            this.txtTagsSearch.TabIndex = 14;
            this.txtTagsSearch.TextChanged += new System.EventHandler(this.TxtTagsSearch_TextChanged);
            this.txtTagsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent_KeyDown);
            // 
            // lblTagsSearch
            // 
            this.lblTagsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTagsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTagsSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTagsSearch.Location = new System.Drawing.Point(21, 14);
            this.lblTagsSearch.Name = "lblTagsSearch";
            this.lblTagsSearch.Size = new System.Drawing.Size(57, 22);
            this.lblTagsSearch.TabIndex = 19;
            this.lblTagsSearch.Text = "Search:";
            // 
            // dgvTags
            // 
            this.dgvTags.AllowUserToAddRows = false;
            this.dgvTags.AllowUserToDeleteRows = false;
            this.dgvTags.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTags.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvTags.EnableHeadersVisualStyles = false;
            this.dgvTags.Location = new System.Drawing.Point(20, 39);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTags.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvTags.RowHeadersWidth = 60;
            this.dgvTags.Size = new System.Drawing.Size(600, 332);
            this.dgvTags.TabIndex = 18;
            this.dgvTags.SelectionChanged += new System.EventHandler(this.DgvTags_SelectionChanged);
            this.dgvTags.DoubleClick += new System.EventHandler(this.DgvTags_DoubleClick);
            // 
            // frmPasswordMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
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
            this.Load += new System.EventHandler(this.FrmPasswordMain_Load);
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
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblTagsCount;
        private System.Windows.Forms.Label lblPasswordsCount;
        private System.Windows.Forms.Label lblUsersCount;
    }
}