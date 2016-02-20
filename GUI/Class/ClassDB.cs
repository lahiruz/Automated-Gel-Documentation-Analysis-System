using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace GelDocUI
{
    static class ClassDB

    {
        static string sqllocalConnectionString = "server=localhost; database=gel_documentation_system; user Id=root; password= ";
        static string sqllocalConnectionString_attadance = "server=localhost; database=gel_documentation_system; user Id=root; password= ";
       
        //Insert or update query execution
        public static int update(string query)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(sqllocalConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        int res = cmd.ExecuteNonQuery();
                        return res;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Insert(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        int res = cmd.ExecuteNonQuery();
                        return res;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////SQL parameterized query execution function

        public static int sqlParameterizedQuery(string query, ArrayList parameteres)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    int result = -1;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        foreach (object parameter in parameteres)
                        {
                            cmd.Parameters.Add((SqlParameter)parameter);
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        result = cmd.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Select one record from Database table
        public static ArrayList selectRecord(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            ArrayList resultArray_toReturn = new ArrayList();

                            int j = 0;
                            int i = dr.FieldCount;

                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    for (j = 0; j <= (i - 1); j++)
                                    {
                                        resultArray_toReturn.Add(dr[j].ToString());
                                    }
                                }
                            }
                            

                            return resultArray_toReturn;

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Select multiple records from Database table
        public static DataTable selectRecords(string query, string[] parameterNames = null, Object[] parameterValues = null,string conName= null)
        {
            try
            {
                using (DataTable dt = new DataTable())
                {
                    if (conName == null)
                    {
                        using (MySqlConnection conn = new MySqlConnection(sqllocalConnectionString))
                        {
                            using (MySqlDataAdapter da = new MySqlDataAdapter())
                            {
                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    if (parameterNames != null)
                                    {

                                        for (int i = 0; i <= parameterNames.Length - 1; i++)
                                        {
                                            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                                        }

                                        cmd.CommandType = CommandType.StoredProcedure;


                                    }


                                    da.SelectCommand = cmd;
                                    conn.Open();
                                    da.SelectCommand.ExecuteNonQuery();
                                    da.Fill(dt);

                                    return dt;
                                }

                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(sqllocalConnectionString_attadance))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    if (parameterNames != null)
                                    {

                                        for (int i = 0; i <= parameterNames.Length - 1; i++)
                                        {
                                            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                                        }

                                        cmd.CommandType = CommandType.StoredProcedure;


                                    }


                                    da.SelectCommand = cmd;
                                    conn.Open();
                                    da.SelectCommand.ExecuteNonQuery();
                                    da.Fill(dt);

                                    return dt;
                                }

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Sql datatable insert at once to Database table
        public static void PerformBulkCopy(DataTable dt, string dest)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqllocalConnectionString))
                {
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int jh = 0; jh < dt.Columns.Count; jh++)
                            {
                                string number = dt.Rows[i][jh].ToString();
                            }
                        }
                        conn.Open();
                        bulkCopy.DestinationTableName = dest;
                        bulkCopy.WriteToServer(dt);
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