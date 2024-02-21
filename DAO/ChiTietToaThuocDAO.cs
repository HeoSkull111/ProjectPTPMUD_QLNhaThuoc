using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    internal class ChiTietToaThuocDAO
    {
        public ChiTietToaThuocDAO() { }
        public DataTable getAllChiTietToaThuoc()
        {
            DataTable dt = new DataTable();
            string query = "Select * from ChiTietToaThuoc";
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
        public DataTable getChiTietToaThuocByID(int _id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from ChiTietToaThuoc where MaToa = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int)
            {
                Value = _id
            };
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
