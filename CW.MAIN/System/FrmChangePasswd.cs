using CW.BO.Business;
using CW.COMMON;
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
    public partial class FrmChangePassword : Form
    {
        #region Property

        #endregion
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        #region Event
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try {
                if (PerformValidation())
                {
                    if (txtNewPasswd.Text != txtRePasswd.Text)
                    {
                        AddFunc.MsgError("Password does not match !");
                        
                    }
                    else
                    {
                        if (txtoldPasswd.Text == txtNewPasswd.Text)
                        {
                            AddFunc.MsgError("New password can not be same old password !");
                        }
                        else {
                            CWUser.ChangePasswordCWUser(txtUsername.Text, txtNewPasswd.Text,txtoldPasswd.Text);
                            AddFunc.MsgInfo("Change Password Succesfull");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddFunc.MsgError(ex.Message);
            }
        }
        #endregion

        #region Method
        private bool PerformValidation()
        {
            bool Result = true;
            string message = AddFunc.CheckControlTextBoxStringEmpty(txtNewPasswd, txtoldPasswd, txtRePasswd, txtUsername);
            if (message != string.Empty)
            {
                AddFunc.MsgError(message);
                Result = false;
            }
            
            return Result;
        }
        #endregion

    }
}
