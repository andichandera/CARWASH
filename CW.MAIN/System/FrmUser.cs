using CW.BO.Business;
using CW.BO.DataModel;
using CW.Common;
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
            _form = FormMode.View;
            LoadComboBox();
            SetupFormMode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgResult.DataSource = CWUser.GetAllUser();

           
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
                dgResult.DataSource = null;
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
            try
            {
                if (PerfomValidation())
                {
                    if (_form == FormMode.New)
                    {
                        CopyGUI2BL();
                        CWUser.AddCWUser(obj);
                        AddFunc.MsgInfo("Add User Succesfull");
                        
                    }
                    else if (_form == FormMode.Update)
                    {

                    }
                    _form = FormMode.View;
                    SetupFormMode();
                }
            }catch(Exception ex){
                AddFunc.MsgError(ex.Message);
            }
        }

        private void LoadComboBox()
        {
            cboEmployee.DataSource = Employee.GetEmployee();
            cboEmployee.ValueMember = "Id";
            cboEmployee.DisplayMember = "Nama";

            cboUserGroup.DataSource = CWUser.GetAllCWUserGroup();
            cboUserGroup.ValueMember = "CWUserGroup";
            cboUserGroup.DisplayMember = "CWUserGroup";
        }

        private void CopyGUI2BL()
        {
            obj.Username = txtUsername.Text;
            obj.Password = txtPassword.Text;
            obj.UsergroupId = cboUserGroup.SelectedValue.ToString();
            obj.EmployeeId = Convert.ToInt16(cboEmployee.SelectedValue);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyBL2GUI();
            _form = FormMode.Update;
            SetupFormMode();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgResult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RowIndex = dgResult.HitTest(e.X, e.Y).RowIndex;
                if (RowIndex >= 0)
                {
                    dgResult.ClearSelection();
                    dgResult.Rows[RowIndex].Selected = true;
                    cms.Show(dgResult, new Point(e.X, e.Y));
                }
            }
        }

        private void CopyBL2GUI()
        {
            cboEmployee.Enabled = false;
            txtUsername.Text = dgResult.Rows[RowIndex].Cells["Username"].Value.ToString();
            txtPassword.Text = dgResult.Rows[RowIndex].Cells["Password"].Value.ToString();
            txtReTypePass.Text = dgResult.Rows[RowIndex].Cells["Password"].Value.ToString();
            cboUserGroup.SelectedValue = "gg";
            dtExpireDate.Text = dgResult.Rows[RowIndex].Cells["ExpireDate"].Value.ToString();
        }
    }
}
