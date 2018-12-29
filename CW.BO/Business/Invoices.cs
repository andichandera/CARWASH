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
    public class Invoices
    {
        public static void AddInvoice(InvoiceDTO _obj)
        {
            try
            {
                DataTable dt = new DataTable();
                DataTable dtt = new DataTable();
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    // Header
                    using (SqlTransaction transactions = connection.BeginTransaction())
                    {
                        try
                        {

                            using (SqlCommand cmd = new SqlCommand("sp_Invoice", connection, transactions))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@CreateBy", CWUser._UserInfo.Username);
                                using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                            }

                            
                            foreach (var det in _obj.Invoice_Detail)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_InvoiceDetail", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@Invoice_Id", Convert.ToInt32(dt.Rows[0]["Id"]));
                                    cmd.Parameters.AddWithValue("@Price", det.Price);
                                    cmd.Parameters.AddWithValue("@Service_Name", det.Service_Name);
                                    using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dtt); }
                                }
                                foreach (var detDetail in det.Worker_detail)
                                {
                                    using (SqlCommand cmd = new SqlCommand("sp_WorkerDetail", connection, transactions))
                                        {
                                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@Emplpoyee_Id", detDetail.Employee_Id);
                                            cmd.Parameters.AddWithValue("@Invoice_Detail_Id", Convert.ToInt32(dtt.Rows[0]["Id"]));
                                            cmd.Parameters.AddWithValue("@CreateBy", CWUser._UserInfo.Username);

                                            cmd.ExecuteNonQuery();
                                        }
                                }

                            }

                            transactions.Commit();
                        }
                        catch (Exception ex)
                        {
                            transactions.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet RetrieveInvoice(string Invoicenumber)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_RetrieveInvoice", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNumber", Invoicenumber);
                    using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(ds); }
                }
            }

            return ds;
        }
    }
}
