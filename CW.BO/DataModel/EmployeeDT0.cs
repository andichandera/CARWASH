using SFIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
   public partial class EmployeeDT0
    {
        #region property 
        public int Id { get; set; }
        public int Nobatch { get; set; }    
        public string Nama { get; set; }
        public string Gender { get; set; }
        public string TTL { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public FormMode EntityState { get; set; }
        public string Description { get; set; }
        public string Jabatan { get; set; }
      
        #endregion

        public EmployeeDT0()
        {
            this.EntityState = FormMode.New;
        }
    }
}
