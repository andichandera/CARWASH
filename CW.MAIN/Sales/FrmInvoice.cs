using CW.BO.Business;
using CW.BO.DataModel;
using CW.COMMON;
using CW.MAIN.Sales;
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
    public partial class FrmInvoice : Form
    {
        #region Property
        private InvoiceDTO _obj = new InvoiceDTO();
        private Invoice_DetailDTO Dto = new Invoice_DetailDTO();
        public decimal Amount = 0;
        private int RowIndex = -1;
        #endregion
        public FrmInvoice()
        {
            InitializeComponent();
            lblCashier.Text = CWUser._UserInfo.Username;
        }

        private void LoadComboBox()
        {
            cbPackages.DataSource = Packages.RetrieveAllPackages();
            cbPackages.DisplayMember = "Package_name";
            cbPackages.ValueMember = "Price";
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            RefreshDG();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PerformValidation())
            {
                txtCustomer.Enabled = false;
                AddTolist();
                FrmInvoiceDetails form = new FrmInvoiceDetails(this.Dto);
                form.ShowDialog();
                RefreshDG();
            }
        }
        private void RefreshDG()
        {
            var source = new BindingSource();
            source.DataSource = _obj.Invoice_Detail;
            dgResult.DataSource = source;
            dgResult = AddFunc.HideSpecificColoum(dgResult, "ID","INVOICE_ID");
            dgResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Amount = _obj.Invoice_Detail.Sum(item => item.Price);
            if(Amount > 1000000)
            {
                _obj.Discount = Amount * 10 / 100;
                Amount = Amount * 90 / 100;
                AddFunc.MsgInfo("You Got a discount");
            }
            else
            {
                _obj.Discount = 0;
                Amount = _obj.Invoice_Detail.Sum(item => item.Price);
            }
            lblPrice.Text = Amount.ToString();
            Dto = new Invoice_DetailDTO();
        }

        private bool PerformValidation()
        {
            bool result = true;
            string message = AddFunc.CheckControlTextBoxStringEmpty(txtBPMobil, txtCustomer, txtMobil);
            if (message != string.Empty)
            {
                AddFunc.MsgError(message);
                result = false;
            }
            if(_obj.Invoice_Detail.Where(x => x.Service_Name == cbPackages.Text).Count() > 0)
            {
                AddFunc.MsgError("This Package Already Add !");
                result = false;
            }
            return result;

        }

        private void AddTolist()
        {
            Dto.NamaMobil = txtMobil.Text + '-' + txtBPMobil.Text;
            Dto.Service_Name = cbPackages.Text;
            Dto.Price = Convert.ToDecimal(cbPackages.SelectedValue.ToString());
            _obj.Invoice_Detail.Add(Dto);
            
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

        private void inputWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice_DetailDTO dtoDetail = _obj.Invoice_Detail.FirstOrDefault(x => x.Service_Name == dgResult.Rows[RowIndex].Cells["Service_Name"].Value.ToString());

            FrmInvoiceDetails form = new FrmInvoiceDetails(dtoDetail.Worker_detail);
            form.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AddFunc.MsgQuesYESNO("Are you sure want to delet this order ?"))
            {
                _obj.Invoice_Detail.RemoveAll(x => x.Service_Name == dgResult.Rows[RowIndex].Cells["Service_Name"].Value.ToString());
            }
            RefreshDG();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try {
                if (dgResult.Rows.Count > 0)
                {
                    if (AddFunc.MsgQuesYESNO("Are you sure want to process this invoices ?"))
                    {
                        _obj.CustomerName = txtCustomer.Text;
                        Invoices.AddInvoice(_obj);
                        AddFunc.MsgInfo("Thank For You Order");
                    }
                }
                else
                {
                    AddFunc.MsgError("No Package added !");
                }
            }
            catch (Exception ex)
            {
                AddFunc.MsgError(ex.Message);
            }
        }

    }
}
