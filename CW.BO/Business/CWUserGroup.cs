using CW.BO.DataModel;
using CW.Common;
using CW.COMMON;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO.Business
{
    public class CWUserGroup
    {
        public static List<FormButtonDTO> RetrieveAllFormButton()
        {
            try
            {
                List<FormButtonDTO> dtos = new List<FormButtonDTO>();

                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    // Header
                    using (SqlCommand cmd = new SqlCommand("sp_GetFormButton", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                    }
                }

                dtos = dt.DataTableToList<FormButtonDTO>();
                dtos.ForEach(x => x.ObjectState = EntityState.Delete);
                return dtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CWUserGroupDTO> RetrieveAllUserGroup()
        {
            try
            {
                List<CWUserGroupDTO> dtos = new List<CWUserGroupDTO>();

                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
                {
                    // Header
                    using (SqlCommand cmd = new SqlCommand("sp_GetSFISUserGroup", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                    }
                }

                dtos = dt.DataTableToList<CWUserGroupDTO>();

                return dtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CWUserGroupRolesDTO> RetrieveAllUserGroupRoles(object UserId = null)
        {
            using (IDbConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", UserId);
                return connection.Query<CWUserGroupRolesDTO>("sp_GetSFISUserGroupRoles", param, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static void UpdateFormButton(List<FormButtonDTO> obj)
        {
            using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transactions = connection.BeginTransaction())
                {
                    try
                    {

                        // Detail
                        foreach (FormButtonDTO formbutton in obj.Where(x => x.ObjectState != EntityState.None))
                        {
                            if (formbutton.ObjectState == EntityState.New)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_AddFormButton", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@FormName", formbutton.FormName);
                                    cmd.Parameters.AddWithValue("@btn1", formbutton.btn1);
                                    cmd.Parameters.AddWithValue("@btn2", formbutton.btn2);
                                    cmd.Parameters.AddWithValue("@btn3", formbutton.btn3);
                                    cmd.Parameters.AddWithValue("@btn4", formbutton.btn4);
                                    cmd.Parameters.AddWithValue("@btn5", formbutton.btn5);
                                    cmd.Parameters.AddWithValue("@btn6", formbutton.btn6);
                                    cmd.Parameters.AddWithValue("@btn7", formbutton.btn7);
                                    cmd.Parameters.AddWithValue("@btn8", formbutton.btn8);
                                    cmd.Parameters.AddWithValue("@btn9", formbutton.btn9);
                                    cmd.Parameters.AddWithValue("@btn10", formbutton.btn10);
                                    cmd.Parameters.AddWithValue("@btn11", formbutton.btn11);
                                    cmd.Parameters.AddWithValue("@btn12", formbutton.btn12);
                                    cmd.Parameters.AddWithValue("@btn13", formbutton.btn13);
                                    cmd.Parameters.AddWithValue("@btn14", formbutton.btn14);
                                    cmd.Parameters.AddWithValue("@btn15", formbutton.btn15);
                                    cmd.Parameters.AddWithValue("@btn16", formbutton.btn16);
                                    cmd.Parameters.AddWithValue("@btn17", formbutton.btn17);
                                    cmd.Parameters.AddWithValue("@btn18", formbutton.btn18);
                                    cmd.Parameters.AddWithValue("@btn19", formbutton.btn19);
                                    cmd.Parameters.AddWithValue("@btn20", formbutton.btn20);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else if (formbutton.ObjectState == EntityState.Update)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_UpdateFormButton", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@FormName", formbutton.FormName);
                                    cmd.Parameters.AddWithValue("@btn1", formbutton.btn1);
                                    cmd.Parameters.AddWithValue("@btn2", formbutton.btn2);
                                    cmd.Parameters.AddWithValue("@btn3", formbutton.btn3);
                                    cmd.Parameters.AddWithValue("@btn4", formbutton.btn4);
                                    cmd.Parameters.AddWithValue("@btn5", formbutton.btn5);
                                    cmd.Parameters.AddWithValue("@btn6", formbutton.btn6);
                                    cmd.Parameters.AddWithValue("@btn7", formbutton.btn7);
                                    cmd.Parameters.AddWithValue("@btn8", formbutton.btn8);
                                    cmd.Parameters.AddWithValue("@btn9", formbutton.btn9);
                                    cmd.Parameters.AddWithValue("@btn10", formbutton.btn10);
                                    cmd.Parameters.AddWithValue("@btn11", formbutton.btn11);
                                    cmd.Parameters.AddWithValue("@btn12", formbutton.btn12);
                                    cmd.Parameters.AddWithValue("@btn13", formbutton.btn13);
                                    cmd.Parameters.AddWithValue("@btn14", formbutton.btn14);
                                    cmd.Parameters.AddWithValue("@btn15", formbutton.btn15);
                                    cmd.Parameters.AddWithValue("@btn16", formbutton.btn16);
                                    cmd.Parameters.AddWithValue("@btn17", formbutton.btn17);
                                    cmd.Parameters.AddWithValue("@btn18", formbutton.btn18);
                                    cmd.Parameters.AddWithValue("@btn19", formbutton.btn19);
                                    cmd.Parameters.AddWithValue("@btn20", formbutton.btn20);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else if (formbutton.ObjectState == EntityState.Delete)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_DeleteFormButton", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@FormName", formbutton.FormName);
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

        public static void UpdateSFISUserGroupRoles(List<CWUserGroupRolesDTO> obj)
        {
            using (SqlConnection connection = new SqlConnection(CWConfiguration.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transactions = connection.BeginTransaction())
                {
                    try
                    {
                        // Detail
                        foreach (CWUserGroupRolesDTO usergrouprole in obj.Where(x => x.ObjectState != EntityState.None))
                        {
                            // foreach (WorkOrderDTO obj in objlist.Where(x => x.ObjectState != EntityState.None))
                            if (usergrouprole.ObjectState == EntityState.New)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_AddSFISUserGroupRoles", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@UserId", usergrouprole.UserId);
                                    cmd.Parameters.AddWithValue("@MenuName", usergrouprole.MenuName);
                                    cmd.Parameters.AddWithValue("@MenuPath", usergrouprole.MenuPath);
                                    cmd.Parameters.AddWithValue("@Permission", usergrouprole.Permission);
                                    cmd.Parameters.AddWithValue("@Tag", usergrouprole.Tag);
                                    cmd.Parameters.AddWithValue("@Parent", usergrouprole.Parent);
                                    cmd.Parameters.AddWithValue("@GrandParent", usergrouprole.GrandParent);
                                    cmd.ExecuteNonQuery();
                                }

                            }
                            else if (usergrouprole.ObjectState == EntityState.Update)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_UpdateSFISUserGroupRoles", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@UserId", usergrouprole.UserId);
                                    cmd.Parameters.AddWithValue("@MenuName", usergrouprole.MenuName);
                                    cmd.Parameters.AddWithValue("@MenuPath", usergrouprole.MenuPath);
                                    cmd.Parameters.AddWithValue("@Permission", usergrouprole.Permission);
                                    cmd.Parameters.AddWithValue("@Tag", usergrouprole.Tag);
                                    cmd.Parameters.AddWithValue("@Parent", usergrouprole.Parent);
                                    cmd.Parameters.AddWithValue("@GrandParent", usergrouprole.GrandParent);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else if (usergrouprole.ObjectState == EntityState.Delete)
                            {
                                using (SqlCommand cmd = new SqlCommand("sp_SFISUserGroupRoles", connection, transactions))
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@UserId", usergrouprole.UserId);
                                    cmd.Parameters.AddWithValue("@MenuPath", usergrouprole.MenuPath);
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
    }
}
