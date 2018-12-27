using CW.BO.DataModel;
using CW.COMMON;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.Business
{
    public class Invoices
    {
        public static void AddInvoice(Invoice_DetailDTO _obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    connection.Open();
                    // Header
                    using (SqlTransaction transactions = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_CRUD_GoodReturnOfPO", connection, transactions))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@XiaomiDocumentNumber", _obj.NamaMobil);
                                cmd.Parameters.AddWithValue("@Remarks", _obj.Price);
                                cmd.Parameters.AddWithValue("@CreatedBy", _obj.Service_Name);
                                cmd.ExecuteNonQuery();
                            }

                            foreach (var det in _obj.Worker_detail)
                                {
                                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_GoodReturnOfPO_Detail", connection, transactions))
                                    {
                                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@GoodsReturnPOId", det.Employee_Id);
                                        cmd.ExecuteNonQuery();
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
    }
}
