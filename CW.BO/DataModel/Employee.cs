using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
   public partial class Employee
    {
        #region property 
        public int Id { get; set; }
        public int Nobatch { get; set; }
        public string Nama { get; set; }
        public string Gender { get; set; }
        public string TTL { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        #endregion
    }
}
