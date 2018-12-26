using CW.BO.Business;
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
    public partial class FrmPackage : Form
    {
        #region Property
        private int RowIndex = -1;
        private FormMode _FormMode;
        private string Id;
        #endregion
        public FrmPackage()
        {
            InitializeComponent();
            _FormMode = FormMode.New;
        }

        #region Method
        private bool PerformValidation()
        {
            bool result = true;
            string message;
            message = AddFunc.CheckControlTextBoxStringEmpty(txtPackageNames);
            if (message != string.Empty)
            {
                AddFunc.MsgError(message);
                result = false;
            }
            message = AddFunc.CheckNumericZero(nmrPrice);
            if (message != string.Empty)
            {
                AddFunc.MsgError(message);
                result = false;
            }
            return result;
        }

        private void RefreshDG()
        {
            dgResult.DataSource = Packages.RetrieveAllPackages();
        }

        private void CopyBL2GUI()
        {
            txtPackageNames.Text = dgResult.Rows[RowIndex].Cells["Package_name"].Value.ToString();
            nmrPrice.Value = Convert.ToDecimal(dgResult.Rows[RowIndex].Cells["Price"].Value);
            Id = dgResult.Rows[RowIndex].Cells["Id"].Value.ToString();
        }
        #endregion

        #region Event
        private void FrmPackage_Load(object sender, EventArgs e)
        {
            RefreshDG();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                if (PerformValidation())
                {
                    if (_FormMode == FormMode.New)
                    {
                        Packages.AddPackages(txtPackageNames.Text, nmrPrice.Value);
                        AddFunc.MsgInfo("Packages Add Succesful");
                    } else if (_FormMode == FormMode.Update)
                    {
                        Packages.EditPackages(Id, txtPackageNames.Text, nmrPrice.Value);
                        AddFunc.MsgInfo("Packages Edit Succesful");
                        _FormMode = FormMode.New;
                    }
                    RefreshDG();

                }
            }
            catch (Exception ex)
            {
                AddFunc.MsgError(ex.Message);
            }
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
            if (RowIndex > -1)
            {
                CopyBL2GUI();
                _FormMode = FormMode.Update;
            }
            else
            {
                AddFunc.MsgError("No Row Selected!");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddFunc.MsgQuesYESNO("Are you sure want to delete this record ?"))
            {
                Packages.DeletePackages(dgResult.Rows[RowIndex].Cells["Id"].Value.ToString());
                AddFunc.MsgInfo("Data Delete Succesfull");
            }
            RefreshDG();
        }
        #endregion
    }
}
