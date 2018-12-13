using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW.COMMON;
using CW.Common;

namespace CW.BO.DataModel
{
    public class CWUserDTO
    {
        #region Property
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UsergroupId { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsActive { get; set; }
        #endregion
        public EntityState ObjectState { get; set; }
        public CWUserDTO()
        {
            this.ObjectState = EntityState.New;
        }
    }
    public class CWUserReadDTO
    {
        #region Property
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UsergroupId { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsActive { get; set; }
        #endregion

        public CWUserReadDTO()
        {

        }

        public CWUserReadDTO(int userId, int EmployeeId,String username, String password, String usergroupId, DateTime expiredDate, Boolean active, DateTime createdDate, String createdBy, DateTime lastModifiedDate, String lastModifiedBy)
        {
            this.UserId = userId;
            this.EmployeeId = EmployeeId;
            this.Username = username;
            this.Password = password;
            this.UsergroupId = usergroupId;
            this.ExpireDate = expiredDate;
            this.IsActive = active;
            this.CreateDate = createdDate;
            this.CreateBy = createdBy;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDate = lastModifiedDate;

        }
    }

}
