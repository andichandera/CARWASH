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
    public class Employee
    {
        public static DataTable GetEmployee(int EmployeeId = 0)
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
                        cmd.Parameters.AddWithValue("@EmployeeId",EmployeeId);
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

        public static DataSet RetrieveEmployee()
        {
            try
            {

                DataSet ds = new DataSet();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllEmployee", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeId", 0);
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(ds); }
                    }
                }

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddEmployee(EmployeeDT0 _obj)
        {
            try {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_Employee", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nama", _obj.Nama);
                        cmd.Parameters.AddWithValue("@Gender", _obj.Gender);
                        cmd.Parameters.AddWithValue("@TTL", _obj.TTL);
                        cmd.Parameters.AddWithValue("@Email", _obj.Email);
                        cmd.Parameters.AddWithValue("@Alamat", _obj.Alamat);
                        cmd.Parameters.AddWithValue("@Jabatan", _obj.Jabatan);
                        cmd.Parameters.AddWithValue("@Department", _obj.Department);
                        cmd.Parameters.AddWithValue("@CWUser", CWUser._UserInfo.Username);
                        cmd.Parameters.AddWithValue("@Mode", "ADD");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EditEmployee(EmployeeDT0 _obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_Employee", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", _obj.Id);
                        cmd.Parameters.AddWithValue("@Nama", _obj.Nama);
                        cmd.Parameters.AddWithValue("@Gender", _obj.Gender);
                        cmd.Parameters.AddWithValue("@TTL", _obj.TTL);
                        cmd.Parameters.AddWithValue("@Email", _obj.Email);
                        cmd.Parameters.AddWithValue("@Alamat", _obj.Alamat);
                        cmd.Parameters.AddWithValue("@Jabatan", _obj.Jabatan);
                        cmd.Parameters.AddWithValue("@Department", _obj.Department);
                        cmd.Parameters.AddWithValue("@CWUser", CWUser._UserInfo.Username);
                        cmd.Parameters.AddWithValue("@Mode", "EDIT");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteEmployee(string Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_Employee", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Mode", "DELETE");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
