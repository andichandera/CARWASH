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

namespace CW.MAIN.Sales
{
    public partial class FrmInvoiceDetails : Form
    {
        #region Property
        private Work_DetailDTO _objs = new Work_DetailDTO();
        private DataTable Dt = new DataTable();
        private Invoice_DetailDTO dto = new Invoice_DetailDTO();
        private List<Work_DetailDTO> lists = new List<Work_DetailDTO>();
        #endregion
        public FrmInvoiceDetails()
        {
            InitializeComponent();
            LoadComboBox();
        }
        public FrmInvoiceDetails(Invoice_DetailDTO dtos)
        {
            InitializeComponent();
            LoadComboBox();
            dto = dtos;
            Dt.Columns.Add("Employee");
        }

        public FrmInvoiceDetails(List<Work_DetailDTO> list)
        {
            InitializeComponent();
            LoadComboBox();
            lists = list;
            RefreshDGList();
        }
        private void LoadComboBox()
        {
            cbEmployee.DataSource = Employee.GetEmployee();
            cbEmployee.DisplayMember = "Nama";
            cbEmployee.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PerformValidation())
            {
                _objs.Employee_Id = Convert.ToInt16(cbEmployee.SelectedValue.ToString());
                dto.Worker_detail.Add(_objs);
                DataRow Row = Dt.NewRow();
                Row["Employee"] = cbEmployee.Text;
                Dt.Rows.Add(Row);
                RefreshDG();
            }
         }
        
        private void FrmInvoiceDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshDG()
        {
            dgResultDetai.DataSource = Dt;
            dgResultDetai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDGList()
        {

            
            //foreach (var x in lists)
            //{
            //    DataRow Row = Dt.NewRow();
            //    Row["Employee"] = Employee.GetEmployee();
            //    Dt.Rows.Add(Row);
            //}
            //RefreshDG();

            //var source = new BindingSource();
            //source.DataSource = lists;
            //dgResultDetai.DataSource = source;
            //dgResultDetai = AddFunc.HideSpecificColoum(dgResultDetai, "ID", "INVOICE_ID");
            //dgResultDetai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private bool PerformValidation()
        {
            bool result = true;
            if (dto.Worker_detail.Where(x => x.Employee_Id == Convert.ToInt16(cbEmployee.SelectedValue.ToString())).ToList().Count> 0)
            {
                AddFunc.MsgError("Employee Already Added");
                result = false;
            }
            return result;
        }
    }
}
