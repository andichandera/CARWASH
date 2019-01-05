using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public partial class InvoiceDTO

    {
        #region property
        public int Id { get; set; }
        public string Invoice_Number { get; set; }
        public string CustomerName { get; set; }
        public decimal Discount { get; set; }
        public DateTime Create_Date { get; set; }
        public string Createby { get; set; }
        public string   Description { get; set; }
        
        public List<Invoice_DetailDTO> Invoice_Detail { get; set; }

        public InvoiceDTO()
        {
            this.Invoice_Detail = new List<Invoice_DetailDTO>();
        }
        #endregion
    }
}
