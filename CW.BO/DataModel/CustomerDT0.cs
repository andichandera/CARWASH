using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public partial class CustomerDT0
    {
        #region Property
        public int Id { get; set; }
        public string Nama { get; set; }
        public int NoHp { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Customer_Group { get; set; }
        public DateTime Create_Date { get; set; }
        public string Createby { get; set; }
        public string Modify { get; set; }
        public string Modifyby { get; set; }

        #endregion
    }
}
