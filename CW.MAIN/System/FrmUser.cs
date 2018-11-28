using CW.BO.Business;
using CW.BO.DataModel;
using CW.COMMON;
using SFIS.Common;
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
    public partial class FrmUser : Form
    {

        #region Property
        private FormMode _form = FormMode.View;
        private List<CWUserDTO> _CWUser = new List<CWUserDTO>();
        private Int32 RowIndex = 0;
        private CWUserDTO obj = new CWUserDTO();
        #endregion

        public FrmUser()
        {
            InitializeComponent();
        }

        #region Event
        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            SetupFormMode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgResult.DataSource = Employee.GetEmployee();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            _form = FormMode.New;
            SetupFormMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _form = FormMode.View;
            SetupFormMode();
        }
        #endregion

        #region Method
        private void SetupFormMode()
        {
            if (_form == FormMode.View)
            {
                btnNew.Enabled = txtSearch.Enabled = btnSearch.Enabled = true;
                btnCancel.Enabled = btnAdd.Enabled = cboEmployee.Enabled = cboUserGroup.Enabled = txtPassword.Enabled = txtReTypePass.Enabled = txtUsername.Enabled = dtExpireDate.Enabled = false;
                cboEmployee.SelectedIndex = cboUserGroup.SelectedIndex = -1;
                txtPassword.Text = txtReTypePass.Text = txtUsername.Text = "";
            }
            else if (_form == FormMode.New)
            {
                btnAdd.Enabled = true;
                txtSearch.Enabled = btnSearch.Enabled = btnNew.Enabled = false;
                btnCancel.Enabled = btnAdd.Enabled = cboEmployee.Enabled = cboUserGroup.Enabled = txtPassword.Enabled = txtReTypePass.Enabled = txtUsername.Enabled = dtExpireDate.Enabled = true;
            }
            else if (_form == FormMode.Update)
            {
                btnAdd.Enabled = true;
                txtSearch.Enabled = btnSearch.Enabled = btnNew.Enabled = false;
                btnCancel.Enabled = btnAdd.Enabled = cboEmployee.Enabled = cboUserGroup.Enabled = txtPassword.Enabled = txtReTypePass.Enabled = txtUsername.Enabled = dtExpireDate.Enabled = true;
            }

        }

        private bool PerfomValidation()
        {
            bool result = true;
            String message = AddFunc.CheckComboBoxValue(cboEmployee, cboUserGroup);
            if (message != string.Empty)
            {
                AddFunc.MsgWarning(message);
                return false;
            }
            message = AddFunc.CheckControlTextBoxStringEmpty(txtPassword, txtReTypePass, txtUsername);
            if (message != string.Empty)
            {
                AddFunc.MsgWarning(message);
                return false;
            }
            if (txtPassword.Text != txtReTypePass.Text)
            {
                AddFunc.MsgWarning("Password wasn't match");
                return false;
            }

            return result;

        }
        #endregion  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PerfomValidation())
            {

            }
        }

        private void LoadComboBox()
        {
            cboEmployee.DataSource = Employee.GetEmployee();
            cboEmployee.ValueMember = "Id";
            cboEmployee.DisplayMember = "Nama";

            cboUserGroup.DataSource = CWUser.GetAllCWUserGroup();
            cboUserGroup.ValueMember = "Id";
            cboUserGroup.DisplayMember = "CWUserGroup";
        }
    }
}
