﻿using CW.BO.DataModel;
using SFIS.Common;
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
        private FormMode _form = FormMode.New;
        private List<CWUserDTO> _CWUser = new List<CWUserDTO>();
        private Int32 RowIndex = 0;
        private CWUserDTO obj = new CWUserDTO();
        #endregion
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
