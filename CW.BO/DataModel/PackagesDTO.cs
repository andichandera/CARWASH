using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public class PackagesDTO
    {
        #region Property
        public int Id { get; set; }
        public string Package_name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public bool IsActive { get; set; }
        #endregion

        public PackagesDTO()
        {

        }
    }
}
