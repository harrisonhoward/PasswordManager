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
            this.tsbPasswordList = new System.Windows.Forms.ToolStripButton();
            this.lblDivider = new System.Windows.Forms.Label();
            this.tscAccount = new System.Windows.Forms.ToolStripComboBox();
            this.lblDividier2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panPasswordList = new System.Windows.Forms.Panel();
            this.txtPasswordSearch = new System.Windows.Forms.TextBox();
            this.lblPasswordSearch = new System.Windows.Forms.Label();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            this.panPasswordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPasswordList,
            this.tscAccount});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsMain_ItemClicked);
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
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-9, 25);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(820, 2);
            this.lblDivider.TabIndex = 1;
            // 
            // tscAccount
            // 
            this.tscAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscAccount.MaxDropDownItems = 2;
            this.tscAccount.Name = "tscAccount";
            this.tscAccount.Size = new System.Drawing.Size(121, 25);
            this.tscAccount.SelectedIndexChanged += new System.EventHandler(this.TscAccount_SelectedIndexChanged);
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
            // frmPasswordMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbPasswordList;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.ToolStripComboBox tscAccount;
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
    }
}