using CW.BO.Business;
using CW.BO.DataModel;
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
    public partial class FrmRegisEmployee : Form
    {
        #region Property
        public EmployeeDT0 _obj = new EmployeeDT0();
        public int RowIndex = -1;
        #endregion
        public FrmRegisEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (PerformValidation())
                {
                    CopyGUI2BL();
                    Employee.AddEmployee(_obj);
                    AddFunc.MsgInfo("Data Add Succesful!");
                    RefresDG();
                }
            }
            catch (Exception ex)
            {
                AddFunc.MsgError(ex.Message);
            }
        }

        private void txtNoBatch_TextChanged(object sender, EventArgs e)
        {

        }

        public void CopyGUI2BL()
        {
            _obj.Nama = Convert.ToString(txtName.Text);
            _obj.TTL = Convert.ToString(txtBornDate.Text);
            _obj.Email = Convert.ToString(txtEmail.Text);
            _obj.Alamat = Convert.ToString(txtAlamat.Text);
            _obj.Description = Convert.ToString(txtDescription);
            _obj.Jabatan = Convert.ToString(Position.Text);
            _obj.Department = Convert.ToString(LstDepartment.Text);
            _obj.Image = Convert.ToString(Picture.Image);

            if (RbMale.Checked)
            {
                _obj.Gender = "Male";
            }
            else
            {
                _obj.Gender = "Female";
            }

        }

        private void FrmRegisEmployee_Load(object sender, EventArgs e)
        {
            RefresDG();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|(*.*)";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    Picture.ImageLocation = imageLocation;
                }
            }


            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private bool PerformValidation()
        {
            bool Result = true;
            string message = AddFunc.CheckControlTextBoxStringEmpty(txtAlamat, txtBornDate, txtDescription, txtEmail, txtName, txtNoBatch);
            string messages = AddFunc.CheckComboBoxValue(LstDepartment, Position);
            if (message != string.Empty)
            {
                AddFunc.MsgError(message);
                Result = false;
            }

            return Result;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefresDG()
        {
            dgResult.DataSource = Employee.GetEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyBL2GUI();
        }

        private void CopyBL2GUI()
        {
            txtName.Text = dgResult.Rows[RowIndex].Cells["Nama"].Value.ToString();
            txtAlamat.Text = dgResult.Rows[RowIndex].Cells["Alamat"].Value.ToString();
            if(dgResult.Rows[RowIndex].Cells["Gender"].Value.ToString() == "Male")
            {
                RbMale.Checked = true;
            }
            else
            {
                RbFemale.Checked = true;
            }
            txtBornDate.Text = dgResult.Rows[RowIndex].Cells["TTL"].Value.ToString();
            txtEmail.Text = dgResult.Rows[RowIndex].Cells["Email"].Value.ToString();
            Position.Text = dgResult.Rows[RowIndex].Cells["Jabatan"].Value.ToString();
            txtDescription.Text = dgResult.Rows[RowIndex].Cells["Description"].Value.ToString();
            LstDepartment.Text = dgResult.Rows[RowIndex].Cells["Department"].Value.ToString();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgResult.Rows.RemoveAt(dgResult.SelectedRows[0].Index);
        }
    }
}

