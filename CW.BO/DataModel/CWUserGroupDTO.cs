using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public class CWUserGroupDTO
    {
        public string Id { get; set; }
        public string GroupName { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public CWUserGroupDTO(string id, string groupName, bool active, DateTime createdDate, string createdBy, Nullable<DateTime> lastModifiedDate, string lastModifiedBy)
        {
            this.Id = id;
            this.GroupName = GroupName;
            this.Active = active;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.LastModifiedDate = lastModifiedDate;
            this.LastModifiedBy = lastModifiedBy;
        }

        public CWUserGroupDTO()
        { }
    }
}
