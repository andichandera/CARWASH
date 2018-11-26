namespace CW.MAIN
{
    partial class FrmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtoldPasswd = new System.Windows.Forms.TextBox();
            this.txtNewPasswd = new System.Windows.Forms.TextBox();
            this.txtRePasswd = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-Type NewPassword";
            // 
            // txtoldPasswd
            // 
            this.txtoldPasswd.Location = new System.Drawing.Point(267, 97);
            this.txtoldPasswd.Name = "txtoldPasswd";
            this.txtoldPasswd.Size = new System.Drawing.Size(176, 20);
            this.txtoldPasswd.TabIndex = 4;
            // 
            // txtNewPasswd
            // 
            this.txtNewPasswd.Location = new System.Drawing.Point(267, 128);
            this.txtNewPasswd.Name = "txtNewPasswd";
            this.txtNewPasswd.Size = new System.Drawing.Size(176, 20);
            this.txtNewPasswd.TabIndex = 5;
            // 
            // txtRePasswd
            // 
            this.txtRePasswd.Location = new System.Drawing.Point(267, 163);
            this.txtRePasswd.Name = "txtRePasswd";
            this.txtRePasswd.Size = new System.Drawing.Size(176, 20);
            this.txtRePasswd.TabIndex = 6;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(360, 212);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(106, 40);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Change Password";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 302);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtRePasswd);
            this.Controls.Add(this.txtNewPasswd);
            this.Controls.Add(this.txtoldPasswd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChangePassword";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtoldPasswd;
        private System.Windows.Forms.TextBox txtNewPasswd;
        private System.Windows.Forms.TextBox txtRePasswd;
        private System.Windows.Forms.Button btnsubmit;
    }
}