using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    internal class ToaThuocDAO
    {
        public ToaThuocDAO() { }
        public DataTable getAllToaThuoc()
        {
            DataTable dt = new DataTable();
            string query = "Select * from ToaThuoc";
            try
            {
                dt = DataProvider.ExecuteSelectAllQuerry(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public DataTable getToaThuocByID(int _id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from ToaThuoc where MaToa = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int)
            {
                Value = _id
            };
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
