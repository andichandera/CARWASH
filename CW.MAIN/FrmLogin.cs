using CW.BO.Business;
using CW.BO.DataModel;
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
    public partial class FrmLogin : Form
    {
        #region Property
        public InvoiceDTO Object = new InvoiceDTO();
        #endregion

        public FrmLogin()
        {
            InitializeComponent();

        }

        #region Event
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PerformValidation())
            {
                CWUser.ValidateUser(txtUsername.Text, txtPassword.Text);
                if (CWUser._UserInfo == null)
                {
                    MessageBox.Show("Please check your user id and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = txtUsername.Text = string.Empty;
                    txtUsername.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {

            }
        }
        #endregion

        #region Method
        private bool PerformValidation()
        {
            bool result = true;

            if (txtUsername.Text == string.Empty)
            {
                result = false;
                MessageBox.Show("Please fill in the username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == string.Empty)
            {
                result = false;
                MessageBox.Show("Please fill in the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }
        #endregion
    }
}
