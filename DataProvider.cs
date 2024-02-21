using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Project
{
    internal class DataProvider
    {
        static SqlConnection con;
        static SqlDataAdapter adapter;
        public DataProvider()
        {
            string constr = ConfigurationManager.ConnectionStrings["QLPK"].ConnectionString;
            con = new SqlConnection(constr);
            adapter = new SqlDataAdapter();
        }
        private static SqlConnection OpenConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["QLPK"].ConnectionString;
            con = new SqlConnection(constr);
            adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }
        //Select ALL
        public static DataTable ExecuteSelectAllQuerry(String _querry)
        {
            SqlCommand myCmd = new SqlCommand();
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                myCmd.Connection = OpenConnection();
                myCmd.CommandText = _querry;
                myCmd.ExecuteNonQuery();

                adapter.SelectCommand = myCmd;
                adapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connect.executeSelectQuery - Query: " + _querry + "\nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }
        //Select By ID
        public static DataTable ExecuteSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            DataTable dataTable = new DataTable();
            //dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCmd.Connection = OpenConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);
                myCmd.ExecuteNonQuery();

                adapter.SelectCommand = myCmd;
                adapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }
        //Insert
        public static bool ExecuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            try
            {
                myCmd.Connection = OpenConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);

                adapter.InsertCommand = myCmd;
                myCmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        //Update Data
        public static bool ExecuteDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            try
            {
                myCmd.Connection = OpenConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);

                adapter.UpdateCommand = myCmd;
                myCmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
    }
}
