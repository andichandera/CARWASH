using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.IO;
using OfficeOpenXml;

namespace CW.BO
{
    public static class MapperHelper
    {

        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            if (row[prop.Name] != DBNull.Value)
                                propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        public static T DataTableToObject<T>(this DataTable table) where T : class, new()
        {
            try
            {
                T obj = new T();

                foreach (var row in table.AsEnumerable())
                {
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            if (row[prop.Name] != DBNull.Value)
                                propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    break;
                }

                return obj;
            }
            catch
            {
                return null;
            }
        }

        //Convert List To Datatable Siang Hua
        public static DataTable AsDataTable<T>(this IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static IEnumerable<T> FileToList<T>(FileInfo file, int startingRow = 2) where T : new()
        {
            List<T> results = new List<T>();

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                int totalRows = workSheet.Dimension.Rows;

                int i = 1;
                
                #region Extract Excel data
                for (i = startingRow; i <= totalRows; i++)
                {
                    var result = new T();
                    //int j = 1;
                    for (int j = 1; j <= workSheet.Dimension.Columns; j++) 
                    {
                        var property = result.GetType().GetProperty(workSheet.Cells[1, j].Value.ToString());
                        var converter = TypeDescriptor.GetConverter(property.PropertyType);
                        property.SetValue(result, converter.ConvertFromString(workSheet.Cells[i, j].Value != null ? workSheet.Cells[i, j].Value.ToString() : null));
                    }

                    //foreach (var item in typeof(T).GetProperties())
                    //{
                    //    var property = result.GetType().GetProperty(item.Name);
                    //    var converter = TypeDescriptor.GetConverter(property.PropertyType);
                    //    property.SetValue(result, converter.ConvertFromString(workSheet.Cells[i, j++].Value != null ? workSheet.Cells[i, j++].Value.ToString() : null));
                    //}
                    results.Add(result);
                }
                #endregion
            }

            return results;
        }

    }
}
