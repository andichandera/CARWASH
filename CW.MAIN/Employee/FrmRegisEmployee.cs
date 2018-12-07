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
    public partial class FrmRegisEmployee : Form
    {
        #region Property
        public EmployeeDT0 _obj = new EmployeeDT0();
        #endregion
        public FrmRegisEmployee()
        {
            InitializeComponent();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtNoBatch_TextChanged(object sender, EventArgs e)
        {

        }

        public  void CopyGUI2BL()
        {
            _obj.Nobatch         = Convert.ToInt32(txtNoBatch.Text);
            _obj.Nama            = Convert.ToString(txtName.Text);
            _obj.TTL             = Convert.ToString(txtBornDate.Text);
            _obj.Email            = Convert.ToString(txtEmail.Text);
            _obj.Alamat            = Convert.ToString(txtAlamat.Text);
            _obj.Description       = Convert.ToString(txtDescription.Text);
            _obj.Jabatan           = Convert.ToString(Position.Text);
            _obj.Department = Convert.ToString(txtDepartment.Text);  

            if (RbMale.Checked)
            {
              cmd.Parameters.AddWithValue("@gender", "Male");
            }

            else
            {
                cmd.Parameters.AddWithValue("@gender", "Female");

            }
        }

        private void FrmRegisEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
