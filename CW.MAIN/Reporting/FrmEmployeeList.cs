using CW.BO.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW.MAIN.Reporting
{
    public partial class FrmEmployeeList : Form
    {
        private DataSet ds = new DataSet();
        public FrmEmployeeList()
        {
            InitializeComponent();
            ds = Employee.RetrieveEmployee();
            CrystalReport1 c = new CrystalReport1();
            c.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = c;
            crystalReportViewer1.Refresh();
        }
    }
}
