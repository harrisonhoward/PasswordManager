namespace PasswordManager {
    partial class frmLogin {
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
            this.panLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbSignedIn = new System.Windows.Forms.CheckBox();
            this.lnkNewUser = new System.Windows.Forms.LinkLabel();
            this.txtMainPassword = new System.Windows.Forms.TextBox();
            this.txtMainUsername = new System.Windows.Forms.TextBox();
            this.lblMainPassword = new System.Windows.Forms.Label();
            this.lblMainUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panCreate = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.btnExit);
            this.panLogin.Controls.Add(this.cbSignedIn);
            this.panLogin.Controls.Add(this.lnkNewUser);
            this.panLogin.Controls.Add(this.txtMainPassword);
            this.panLogin.Controls.Add(this.txtMainUsername);
            this.panLogin.Controls.Add(this.lblMainPassword);
            this.panLogin.Controls.Add(this.lblMainUsername);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.lblMainTitle);
            this.panLogin.Location = new System.Drawing.Point(0, 0);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(344, 342);
            this.panLogin.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(275, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // cbSignedIn
            // 
            this.cbSignedIn.AutoSize = true;
            this.cbSignedIn.Checked = global::PasswordManager.Properties.Settings.Default.StaySignedIn;
            this.cbSignedIn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PasswordManager.Properties.Settings.Default, "StaySignedIn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbSignedIn.Location = new System.Drawing.Point(182, 204);
            this.cbSignedIn.Name = "cbSignedIn";
            this.cbSignedIn.Size = new System.Drawing.Size(95, 17);
            this.cbSignedIn.TabIndex = 4;
            this.cbSignedIn.Text = "Stay Signed In";
            this.cbSignedIn.UseVisualStyleBackColor = true;
            // 
            // lnkNewUser
            // 
            this.lnkNewUser.AutoSize = true;
            this.lnkNewUser.Location = new System.Drawing.Point(41, 205);
            this.lnkNewUser.Name = "lnkNewUser";
            this.lnkNewUser.Size = new System.Drawing.Size(112, 13);
            this.lnkNewUser.TabIndex = 3;
            this.lnkNewUser.TabStop = true;
            this.lnkNewUser.Text = "Create a new account";
            this.lnkNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNewUser_LinkClicked);
            // 
            // txtMainPassword
            // 
            this.txtMainPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPassword.Location = new System.Drawing.Point(122, 172);
            this.txtMainPassword.MaxLength = 60;
            this.txtMainPassword.Name = "txtMainPassword";
            this.txtMainPassword.Size = new System.Drawing.Size(155, 22);
            this.txtMainPassword.TabIndex = 1;
            this.txtMainPassword.UseSystemPasswordChar = true;
            this.txtMainPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMainPassword_KeyDown);
            this.txtMainPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMainPassword_KeyPress);
            // 
            // txtMainUsername
            // 
            this.txtMainUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainUsername.Location = new System.Drawing.Point(122, 116);
            this.txtMainUsername.MaxLength = 60;
            this.txtMainUsername.Name = "txtMainUsername";
            this.txtMainUsername.Size = new System.Drawing.Size(155, 22);
            this.txtMainUsername.TabIndex = 0;
            // 
            // lblMainPassword
            // 
            this.lblMainPassword.AutoSize = true;
            this.lblMainPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPassword.Location = new System.Drawing.Point(41, 173);
            this.lblMainPassword.Name = "lblMainPassword";
            this.lblMainPassword.Size = new System.Drawing.Size(75, 18);
            this.lblMainPassword.TabIndex = 12;
            this.lblMainPassword.Text = "Password";
            // 
            // lblMainUsername
            // 
            this.lblMainUsername.AutoSize = true;
            this.lblMainUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUsername.Location = new System.Drawing.Point(39, 117);
            this.lblMainUsername.Name = "lblMainUsername";
            this.lblMainUsername.Size = new System.Drawing.Size(77, 18);
            this.lblMainUsername.TabIndex = 11;
            this.lblMainUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(119, 288);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(64, 38);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(213, 25);
            this.lblMainTitle.TabIndex = 9;
            this.lblMainTitle.Text = "Password Manager";
            // 
            // panCreate
            // 
            this.panCreate.Controls.Add(this.btnClose);
            this.panCreate.Controls.Add(this.txtConfirm);
            this.panCreate.Controls.Add(this.lblConfirm);
            this.panCreate.Controls.Add(this.txtPassword);
            this.panCreate.Controls.Add(this.txtUsername);
            this.panCreate.Controls.Add(this.lblPassword);
            this.panCreate.Controls.Add(this.lblUsername);
            this.panCreate.Controls.Add(this.btnCreate);
            this.panCreate.Controls.Add(this.lblCreate);
            this.panCreate.Location = new System.Drawing.Point(0, 0);
            this.panCreate.Name = "panCreate";
            this.panCreate.Size = new System.Drawing.Size(344, 342);
            this.panCreate.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(275, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(148, 200);
            this.txtConfirm.MaxLength = 60;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(155, 22);
            this.txtConfirm.TabIndex = 9;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirm_KeyDown);
            this.txtConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirm_KeyPress);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(10, 201);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(132, 18);
            this.lblConfirm.TabIndex = 21;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(148, 172);
            this.txtPassword.MaxLength = 60;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(148, 116);
            this.txtUsername.MaxLength = 60;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(67, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(65, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 18);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(115, 288);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 40);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(80, 38);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(191, 25);
            this.lblCreate.TabIndex = 15;
            this.lblCreate.Text = "Account Creation";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 343);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panCreate.ResumeLayout(false);
            this.panCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbSignedIn;
        private System.Windows.Forms.LinkLabel lnkNewUser;
        private System.Windows.Forms.TextBox txtMainPassword;
        private System.Windows.Forms.TextBox txtMainUsername;
        private System.Windows.Forms.Label lblMainPassword;
        private System.Windows.Forms.Label lblMainUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panCreate;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnClose;
    }
}