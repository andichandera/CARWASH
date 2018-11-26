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
                    cmd.Parameters.AddWithValue("@NoBatch",_obj.Nobatch);
                    cmd.Parameters.AddWithValue("@NoBatch", _obj.Nobatch);
                    cmd.Parameters.AddWithValue("@CWUser", CWUser._UserInfo.Username);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
