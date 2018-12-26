namespace CW.MAIN
{
    partial class FrmRegisEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoBatch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.ComboBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Button();
            this.LstDepartment = new System.Windows.Forms.ComboBox();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Batch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tempat Tanggal Lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Jabatan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Deskripsi";
            // 
            // txtNoBatch
            // 
            this.txtNoBatch.Enabled = false;
            this.txtNoBatch.Location = new System.Drawing.Point(388, 48);
            this.txtNoBatch.Name = "txtNoBatch";
            this.txtNoBatch.Size = new System.Drawing.Size(213, 20);
            this.txtNoBatch.TabIndex = 9;
            this.txtNoBatch.Text = "Auto Generated";
            this.txtNoBatch.TextChanged += new System.EventHandler(this.txtNoBatch_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Name";
            this.txtName.Location = new System.Drawing.Point(388, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtAlamat
            // 
            this.txtAlamat.AccessibleName = "Alamat";
            this.txtAlamat.Location = new System.Drawing.Point(388, 110);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(213, 20);
            this.txtAlamat.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "Email";
            this.txtEmail.Location = new System.Drawing.Point(388, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.AccessibleName = "Deskripsi";
            this.txtDescription.Location = new System.Drawing.Point(390, 262);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(213, 20);
            this.txtDescription.TabIndex = 16;
            // 
            // txtBornDate
            // 
            this.txtBornDate.AccessibleName = "Tempat Tanggal Lahir";
            this.txtBornDate.Location = new System.Drawing.Point(388, 175);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.Size = new System.Drawing.Size(213, 20);
            this.txtBornDate.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(392, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 51);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(462, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 51);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Position
            // 
            this.Position.AccessibleName = "Jabatan";
            this.Position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Manager",
            "Staff"});
            this.Position.Location = new System.Drawing.Point(390, 235);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(213, 21);
            this.Position.TabIndex = 22;
            this.Position.SelectedIndexChanged += new System.EventHandler(this.Position_SelectedIndexChanged);
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(62, 55);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(100, 116);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 23;
            this.Picture.TabStop = false;
            // 
            // RbMale
            // 
            this.RbMale.AccessibleName = "Male";
            this.RbMale.AutoSize = true;
            this.RbMale.Location = new System.Drawing.Point(388, 147);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(48, 17);
            this.RbMale.TabIndex = 24;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // RbFemale
            // 
            this.RbFemale.AccessibleName = "Female";
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(500, 147);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(59, 17);
            this.RbFemale.TabIndex = 25;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(870, 80);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 26;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(651, 83);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 20);
            this.txtsearch.TabIndex = 27;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(636, 147);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(316, 186);
            this.dgResult.TabIndex = 28;
            this.dgResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgResult_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Department";
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(74, 182);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(75, 39);
            this.Image.TabIndex = 31;
            this.Image.Text = "Image";
            this.Image.UseVisualStyleBackColor = true;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // LstDepartment
            // 
            this.LstDepartment.AccessibleName = "Department";
            this.LstDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LstDepartment.FormattingEnabled = true;
            this.LstDepartment.Items.AddRange(new object[] {
            "Accounting",
            "Worker",
            "Director"});
            this.LstDepartment.Location = new System.Drawing.Point(388, 294);
            this.LstDepartment.Name = "LstDepartment";
            this.LstDepartment.Size = new System.Drawing.Size(213, 21);
            this.LstDepartment.TabIndex = 32;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(113, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FrmRegisEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 463);
            this.Controls.Add(this.LstDepartment);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.RbFemale);
            this.Controls.Add(this.RbMale);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBornDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNoBatch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegisEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmRegisEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoBatch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.ComboBox LstDepartment;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}