namespace PasswordManager {
    partial class frmLoading {
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.panBar = new System.Windows.Forms.Panel();
            this.panSlider = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(85, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Password Manager";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.Gray;
            this.lblLoad.Location = new System.Drawing.Point(140, 153);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(103, 25);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Loading...";
            // 
            // panBar
            // 
            this.panBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.panBar.Controls.Add(this.panSlider);
            this.panBar.Location = new System.Drawing.Point(90, 210);
            this.panBar.Name = "panBar";
            this.panBar.Size = new System.Drawing.Size(208, 15);
            this.panBar.TabIndex = 2;
            // 
            // panSlider
            // 
            this.panSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(109)))), ((int)(((byte)(137)))));
            this.panSlider.Location = new System.Drawing.Point(0, 0);
            this.panSlider.Name = "panSlider";
            this.panSlider.Size = new System.Drawing.Size(70, 15);
            this.panSlider.TabIndex = 3;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(382, 360);
            this.Controls.Add(this.panBar);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.panBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Panel panBar;
        private System.Windows.Forms.Panel panSlider;
        private System.Windows.Forms.Timer timerLoad;
    }
}