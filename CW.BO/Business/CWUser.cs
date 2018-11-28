using CW.BO.DataModel;
using CW.COMMON;
using SFIS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.Business
{
    public partial class CWUser
    {
        public static CWUserReadDTO _UserInfo { get; internal set; }

        public static void ValidateUser(string Username, string Password)
        {
            try
            {
                _UserInfo = null;

                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ValidatioSFISnUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", Username);
                        cmd.Parameters.AddWithValue("@Password", Encryptor.EncryptStringRijndaelToHexString(Password));
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                        cmd.ExecuteNonQuery();

                        if (dt.Rows.Count > 0)
                        {
                            CWUserDTO dto = dt.DataTableToObject<CWUserDTO>();

                            _UserInfo = new CWUserReadDTO(dto.UserId, dto.Username, dto.Password, dto.UsergroupId, dto.ExpireDate, dto.IsActive, dto.CreateDate, dto.CreateBy, dto.LastModifiedDate, dto.LastModifiedBy);
                            //_UserGroupRoles = SFISUserGroup.RetrieveAllUserGroupRoles(dto.UserId);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<CWUserDTO> GetAllUser(string Username="")
        {
            try
            {
                List<CWUserDTO> _obj = new List<CWUserDTO>();

                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    // Header
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", Username);
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                    }
                }

                _obj = dt.DataTableToList<CWUserDTO>();
                _obj.ForEach(x => x.ObjectState = EntityState.None);

                return _obj;
            }catch(Exception ex){
                throw ex;
            }
        }

        public static DataTable GetAllCWUserGroup()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllCWUserGroup", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
