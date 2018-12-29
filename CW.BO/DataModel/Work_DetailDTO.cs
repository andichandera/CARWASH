using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public partial class Work_DetailDTO
    {
        #region property 
        public int Id { get; set; }

        public int Employee_Id { get; set; }
        public int Invoice_Detail_Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }

        
        #endregion
    }
}
