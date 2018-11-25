using CW.BO.Business;
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
    public partial class FrmLogin : Form
    {
        #region Property
        public InvoiceDTO Object = new InvoiceDTO();
        #endregion
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
