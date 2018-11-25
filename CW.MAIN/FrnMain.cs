using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW.MAIN
{
    public partial class FrnMain : Form
    {
        #region Property
        string nmSpace = string.Empty;
        #endregion
        public FrnMain()
        {
            InitializeComponent();
            nmSpace = this.GetType().Namespace;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenNewForm(nmSpace, "FrmChangePassword");
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
                    form.Show();
                    form.Location = new Point(0, 0);
                    //form.Size = this.ClientRectangle.Size;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "System Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}
