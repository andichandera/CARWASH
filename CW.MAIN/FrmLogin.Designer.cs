namespace CW.MAIN
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new DevComponents.DotNetBar.LabelX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(616, 35);
            this.pnlColor.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(21, 82);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(583, 40);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            // 
            // 
            // 
            this.lblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(21, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 23);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "USERNAME :";
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "PASSW0RD :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 176);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(583, 40);
            this.txtPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Location = new System.Drawing.Point(478, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 33);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(311, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 33);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(616, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtUsername;
        private DevComponents.DotNetBar.LabelX lblUsername;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}

