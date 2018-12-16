using CW.BO.DataModel;
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
    public partial class Employee
    {
        public static DataTable GetEmployee()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllEmployee", connection))
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

        public static void AddEmployee(EmployeeDT0 _obj)
        {
            using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_CRUD_Employee", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nobatch", _obj.Nobatch);
                    cmd.Parameters.AddWithValue("@Nama", _obj.Nama);
                    cmd.Parameters.AddWithValue("@Gender", _obj.Gender);
                    cmd.Parameters.AddWithValue("@TTL", _obj.TTL);
                    cmd.Parameters.AddWithValue("@Email", _obj.Email);
                    cmd.Parameters.AddWithValue("@Alamat", _obj.Alamat);
                    cmd.Parameters.AddWithValue("@Jabatan", _obj.Jabatan);
                    cmd.Parameters.AddWithValue("@Department", _obj.Department);
                    cmd.Parameters.AddWithValue("@CWUser", CWUser._UserInfo.Username);
                    cmd.Parameters.AddWithValue("@Mode", "ADD");
                    cmd.Parameters.AddWithValue("@CreateDate", _obj.CreateDate);
                    cmd.Parameters.AddWithValue("@Createby", _obj.CreateBy);
                    cmd.Parameters.AddWithValue("@ModifiedDate", _obj.ModifiedDate);
                    cmd.Parameters.AddWithValue("@ModifiedBy", _obj.ModifiedBy);
                    cmd.Parameters.AddWithValue("@Description", _obj.Description);
                    cmd.Parameters.AddWithValue("@Image", _obj.Image);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
