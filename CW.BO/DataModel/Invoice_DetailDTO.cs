using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public partial class Invoice_DetailDTO
    {
        #region Property
        public int Id { get; set; }

        public int Invoice_Id { get; set; }

        public decimal Price { get; set; }

        public string Service_Name { get; set; }
        #endregion
    }
}
