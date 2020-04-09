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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPasswordList = new System.Windows.Forms.ToolStripButton();
            this.tsdAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDividier2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panPasswordList = new System.Windows.Forms.Panel();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.txtPasswordSearch = new System.Windows.Forms.TextBox();
            this.lblPasswordSearch = new System.Windows.Forms.Label();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.panAccountSettings = new System.Windows.Forms.Panel();
            this.gbAdminSettings = new System.Windows.Forms.GroupBox();
            this.gbUserSettings = new System.Windows.Forms.GroupBox();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAccountSave = new System.Windows.Forms.Button();
            this.gbAccountDanger = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnDeletePasswords = new System.Windows.Forms.Button();
            this.tsMain.SuspendLayout();
            this.panPasswordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.panAccountSettings.SuspendLayout();
            this.gbUserSettings.SuspendLayout();
            this.gbAccountDanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAccount,
            this.toolStripSeparator1,
            this.tsbPasswordList,
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.tsbPasswordList.ToolTipText = "Display the all your passwords";
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
            this.btnDeletePassword.TabIndex = 12;
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
            this.btnEditPassword.TabIndex = 11;
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
            this.btnNewPassword.TabIndex = 10;
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
            this.txtPasswordSearch.Size = new System.Drawing.Size(543, 22);
            this.txtPasswordSearch.TabIndex = 9;
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
            this.dgvPasswords.RowHeadersWidth = 60;
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
            this.gbAdminSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdminSettings.Location = new System.Drawing.Point(400, 16);
            this.gbAdminSettings.Name = "gbAdminSettings";
            this.gbAdminSettings.Size = new System.Drawing.Size(382, 357);
            this.gbAdminSettings.TabIndex = 1;
            this.gbAdminSettings.TabStop = false;
            this.gbAdminSettings.Text = "Admin Settings";
            // 
            // gbUserSettings
            // 
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
            // txtChangePassword
            // 
            this.txtChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword.Location = new System.Drawing.Point(6, 31);
            this.txtChangePassword.MaxLength = 60;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(155, 22);
            this.txtChangePassword.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(167, 27);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 29);
            this.btnChangePassword.TabIndex = 21;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // btnAccountSave
            // 
            this.btnAccountSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSave.Location = new System.Drawing.Point(292, 323);
            this.btnAccountSave.Name = "btnAccountSave";
            this.btnAccountSave.Size = new System.Drawing.Size(84, 28);
            this.btnAccountSave.TabIndex = 15;
            this.btnAccountSave.Text = "Save";
            this.btnAccountSave.UseVisualStyleBackColor = true;
            this.btnAccountSave.Click += new System.EventHandler(this.BtnAccountSave_Click);
            // 
            // gbAccountDanger
            // 
            this.gbAccountDanger.Controls.Add(this.btnDeletePasswords);
            this.gbAccountDanger.Controls.Add(this.btnDeleteAccount);
            this.gbAccountDanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbAccountDanger.Location = new System.Drawing.Point(6, 251);
            this.gbAccountDanger.Name = "gbAccountDanger";
            this.gbAccountDanger.Size = new System.Drawing.Size(200, 100);
            this.gbAccountDanger.TabIndex = 15;
            this.gbAccountDanger.TabStop = false;
            this.gbAccountDanger.Text = "Danger Zone";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(33, 22);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(132, 29);
            this.btnDeleteAccount.TabIndex = 22;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnDeletePasswords
            // 
            this.btnDeletePasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePasswords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletePasswords.Location = new System.Drawing.Point(33, 57);
            this.btnDeletePasswords.Name = "btnDeletePasswords";
            this.btnDeletePasswords.Size = new System.Drawing.Size(132, 29);
            this.btnDeletePasswords.TabIndex = 23;
            this.btnDeletePasswords.Text = "Delete Passwords";
            this.btnDeletePasswords.UseVisualStyleBackColor = true;
            this.btnDeletePasswords.Click += new System.EventHandler(this.BtnDeletePasswords_Click);
            // 
            // frmPasswordMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panAccountSettings);
            this.Controls.Add(this.panPasswordList);
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
            this.gbUserSettings.ResumeLayout(false);
            this.gbUserSettings.PerformLayout();
            this.gbAccountDanger.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panAccountSettings;
        private System.Windows.Forms.GroupBox gbUserSettings;
        private System.Windows.Forms.GroupBox gbAdminSettings;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox gbAccountDanger;
        private System.Windows.Forms.Button btnDeletePasswords;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAccountSave;
    }
}