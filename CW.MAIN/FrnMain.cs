using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CW.COMMON;
using CW.BO.DataModel;
using CW.MAIN.Reporting;

namespace CW.MAIN
{
    public partial class FrnMain : Form
    {
        #region Property
        string nmSpace = string.Empty;
        private CWUserDTO _user = new CWUserDTO();
        public CWUserDTO User
        #endregion
        { get { return _user; } }
        public FrnMain()
        {
            InitializeComponent();
            nmSpace = this.GetType().Namespace;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmChangePassword");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAbout frmMaterialRec = new FrmAbout();

                bool isFound = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == frmMaterialRec.Name)
                    { frm.BringToFront(); isFound = true; break; }
                }

                if (!isFound)
                {
                    frmMaterialRec.Show();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "System Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region Method
        private void OpenNewForm(String nameSpace, String formName)
        {
            try
            {
                bool isFound = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == formName)
                    { frm.BringToFront(); isFound = true; break; }
                }

                if (!isFound)
                {
                    var form = (Form)Activator.CreateInstance(Type.GetType(nameSpace + "." + formName));
                    form.MdiParent = this;
                    form.Show();
                    form.Location = new Point(0, 0);
                    //form.Size = this.ClientRectangle.Size;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "System Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        private void FrnMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Left = this.Top = 0;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                Screen screen = AddFunc.GetSecondaryScreen();
                //this.Location = screen.WorkingArea.Location;
                //this.Size = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrnMain_Shown(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            FrmLogin form = new FrmLogin();
            DialogResult dr = form.ShowDialog();
            if (dr != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                AddFunc.MsgInfo("Login Succesfull");
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmUser");
        }

        private void listOfEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmRegisEmployee");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }
       private void userGroupRolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmUserGroupRoles");
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmPackage"); 
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmInvoice");
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(nmSpace, "FrmSalary");
        }

        private void listEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeList form = new FrmEmployeeList();
            form.ShowDialog(); 
        }
    }
}
