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
                    using (SqlCommand cmd = new SqlCommand("sp_ValidatioCWUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Encryptor.EncryptStringRijndaelToHexString(Password));
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                        cmd.ExecuteNonQuery();

                        if (dt.Rows.Count > 0)
                        {
                            CWUserDTO dto = dt.DataTableToObject<CWUserDTO>();

                            _UserInfo = new CWUserReadDTO(dto.UserId, dto.EmployeeId ,dto.Username, dto.Password, dto.UsergroupId, dto.ExpireDate, dto.IsActive, dto.CreateDate, dto.CreateBy, dto.LastModifiedDate, dto.LastModifiedBy);
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
                        cmd.Parameters.AddWithValue("@Username", Username);
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

        public static void AddCWUser(CWUserDTO _obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_CWUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeId", _obj.EmployeeId);
                        cmd.Parameters.AddWithValue("@Username", _obj.Username);
                        cmd.Parameters.AddWithValue("@Password", Encryptor.EncryptStringRijndaelToHexString(_obj.Password));
                        cmd.Parameters.AddWithValue("@UsergroupId", _obj.UsergroupId);
                        cmd.Parameters.AddWithValue("@CWUser", "User");
                        cmd.Parameters.AddWithValue("@Mode", "ADD");
                        cmd.ExecuteNonQuery();

                    }
                }
            }catch(Exception ex){
                throw ex;
            }
        }

        public static void ChangePasswordCWUser(string Username, string Password, string OldPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ChangePasswordCWUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@OldPassword", Encryptor.EncryptStringRijndaelToHexString(OldPassword));
                        cmd.Parameters.AddWithValue("@Password", Encryptor.EncryptStringRijndaelToHexString(Password));
                        cmd.Parameters.AddWithValue("@LastModifiedBy", CWUser._UserInfo.Username);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
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
