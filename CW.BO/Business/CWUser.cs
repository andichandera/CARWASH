﻿using CW.BO.DataModel;
using CW.COMMON;
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
    }
}