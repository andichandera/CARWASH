using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmCrystalReport : Form
    {
        private ReportDocument reportDoc = new ReportDocument();
        private DataSet ds = new DataSet();
        public FrmCrystalReport()
        {
            InitializeComponent();
        }

        private void FrmCrystalReport_Load(object sender, EventArgs e)
        {
            CRV.ReportSource = reportDoc;
        }

        public void PrintInvoice(string DocumentNumber)
        {
            //try
            //{
            //    ds = IQCInspection.RetreiveVDCSPrint(DocumentNumber);
            string filePath = Application.StartupPath + @"\Sales\CrystalReport1.rpt";
            reportDoc.Load(filePath);
            reportDoc.SetDataSource(ds.Tables[0]);

            //    foreach (DataRow dtRow in ds.Tables[1].Rows)
            //    {
            //        if (dtRow["QuestionId"].ToString() == "1")
            //        {
            //            reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"], dtRow["Answer"].ToString());
            //        }
            //        else if (dtRow["QuestionId"].ToString() == "5")
            //        {
            //            if (dtRow["Answer"].ToString().ToUpper() == "RETURN")
            //            {
            //                reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"] + "_1", "X");
            //                reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"] + "_2", "");
            //            }
            //            else
            //            {
            //                reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"] + "_1", "");
            //                reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"] + "_2", "X");
            //            }
            //        }
            //        else
            //        {
            //            reportDocument.SetParameterValue("Qst" + dtRow["QuestionId"], dtRow["Answer"].ToString() == "YES" ? "X" : dtRow["Answer"].ToString() == "NO" ? "" : dtRow["Answer"].ToString());
            //        }
            //    }
            //    reportDocument.SetParameterValue("PrintedBy", "Printed By : " + SFISUser._UserInfo.UserId);
            //    CRV.ShowExportButton = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
