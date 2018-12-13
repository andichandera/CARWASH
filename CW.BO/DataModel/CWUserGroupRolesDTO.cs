using CW.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.DataModel
{
    public class CWUserGroupRolesDTO
    {
        public string UserId { get; set; }
        public string MenuPath { get; set; }
        public string MenuName { get; set; }
        public bool Permission { get; set; }
        public string Tag { get; set; }
        public string Parent { get; set; }
        public string GrandParent { get; set; }
        public string elementName { get; set; }
        public EntityState ObjectState { get; set; }
        public CWUserGroupRolesDTO()
        { this.ObjectState = EntityState.None; }
    }
}
