﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public partial class Work_Detail
    {
        #region property 
        public int Id { get; set; }
        public int Invoice_Number { get; set; }
        public DateTime Create_Date { get; set; }
        public string Createby { get; set; }
        public string Description { get; set; }
        #endregion
    }
}