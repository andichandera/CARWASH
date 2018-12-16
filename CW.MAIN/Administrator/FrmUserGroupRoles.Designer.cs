namespace CW.MAIN
{
    partial class FrmUserGroupRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserGroupRoles));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboUser = new System.Windows.Forms.ListBox();
            this.lboUserGroup = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.tvUserGroupRoles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvUserGroupRoles);
            this.splitContainer1.Size = new System.Drawing.Size(702, 546);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lboUserGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 544);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lboUser
            // 
            this.lboUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboUser.FormattingEnabled = true;
            this.lboUser.Location = new System.Drawing.Point(2, 183);
            this.lboUser.Margin = new System.Windows.Forms.Padding(2);
            this.lboUser.Name = "lboUser";
            this.lboUser.Size = new System.Drawing.Size(226, 177);
            this.lboUser.TabIndex = 1;
            this.lboUser.SelectedIndexChanged += new System.EventHandler(this.lboUser_SelectedIndexChanged);
            // 
            // lboUserGroup
            // 
            this.lboUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboUserGroup.FormattingEnabled = true;
            this.lboUserGroup.Location = new System.Drawing.Point(2, 2);
            this.lboUserGroup.Margin = new System.Windows.Forms.Padding(2);
            this.lboUserGroup.Name = "lboUserGroup";
            this.lboUserGroup.Size = new System.Drawing.Size(226, 177);
            this.lboUserGroup.TabIndex = 0;
            this.lboUserGroup.SelectedIndexChanged += new System.EventHandler(this.lboUserGroup_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnclose, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 364);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(116, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 33);
            this.btnclose.TabIndex = 9;
            this.btnclose.TabStop = false;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tvUserGroupRoles
            // 
            this.tvUserGroupRoles.CheckBoxes = true;
            this.tvUserGroupRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUserGroupRoles.ImageIndex = 0;
            this.tvUserGroupRoles.ImageList = this.imageList1;
            this.tvUserGroupRoles.Location = new System.Drawing.Point(0, 0);
            this.tvUserGroupRoles.Margin = new System.Windows.Forms.Padding(2);
            this.tvUserGroupRoles.Name = "tvUserGroupRoles";
            this.tvUserGroupRoles.SelectedImageIndex = 0;
            this.tvUserGroupRoles.Size = new System.Drawing.Size(465, 546);
            this.tvUserGroupRoles.TabIndex = 0;
            this.tvUserGroupRoles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvUserGroupRoles_AfterCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder");
            this.imageList1.Images.SetKeyName(1, "Abort");
            this.imageList1.Images.SetKeyName(2, "Approved");
            this.imageList1.Images.SetKeyName(3, "Close");
            this.imageList1.Images.SetKeyName(4, "Confirm");
            this.imageList1.Images.SetKeyName(5, "Delete");
            this.imageList1.Images.SetKeyName(6, "Edit");
            this.imageList1.Images.SetKeyName(7, "Exit");
            this.imageList1.Images.SetKeyName(8, "Generate");
            this.imageList1.Images.SetKeyName(9, "New");
            this.imageList1.Images.SetKeyName(10, "Posting");
            this.imageList1.Images.SetKeyName(11, "Save");
            this.imageList1.Images.SetKeyName(12, "Cancel");
            this.imageList1.Images.SetKeyName(13, "Link");
            this.imageList1.Images.SetKeyName(14, "Print");
            this.imageList1.Images.SetKeyName(15, "Find");
            this.imageList1.Images.SetKeyName(16, "Import");
            this.imageList1.Images.SetKeyName(17, "Export");
            this.imageList1.Images.SetKeyName(18, "Add To List");
            this.imageList1.Images.SetKeyName(19, "Process");
            this.imageList1.Images.SetKeyName(20, "Report");
            this.imageList1.Images.SetKeyName(21, "Scan");
            this.imageList1.Images.SetKeyName(22, "Send Approve");
            // 
            // FrmUserGroupRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 546);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUserGroupRole";
            this.Text = "User Group Roles";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lboUser;
        private System.Windows.Forms.ListBox lboUserGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tvUserGroupRoles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ImageList imageList1;
    }
}