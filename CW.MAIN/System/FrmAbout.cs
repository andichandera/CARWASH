using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CW.COMMON;

namespace CW.MAIN
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        #region Event
        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblCompany.Text = CWConfiguration.Company;
            lblSystemName.Text = " CW - " + Application.ProductVersion;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
