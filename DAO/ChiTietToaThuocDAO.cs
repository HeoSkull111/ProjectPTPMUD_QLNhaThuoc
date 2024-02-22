using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DTO;

namespace Project.DAO
{
    internal class ChiTietToaThuocDAO
    {
        public ChiTietToaThuocDAO() { }
        private string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLPhongKham;Integrated Security=True";
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
        public void AddCTTT(ChiTietToaThuoc cttt)
        {
            string q = "INSERT INTO ChiTietToaThuoc ([MaToa], [MaThuoc], [SoLuong], [CachDung]) " +
                        "VALUES (@MaToa, @MaThuoc, @SoLuong, @CachDung)";
            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaToa", cttt.MaToa);
                command.Parameters.AddWithValue("@MaThuoc", cttt.MaThuoc);
                command.Parameters.AddWithValue("@SoLuong", cttt.SoLuong);
                command.Parameters.AddWithValue("@CachDung", cttt.CachDung);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteCTTT(string maThuoc)
        {
            try
            {
                string q = "DELETE FROM ChiTietToaThuoc WHERE [MaThuoc] = @MaThuoc";

                using (SqlConnection connection = new SqlConnection(cons))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    command.Parameters.AddWithValue("@MaThuoc", maThuoc);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateCTTT(ChiTietToaThuoc cttt)
        {
            string q = "UPDATE ChiTietToaThuoc SET [MaToa] = @MaToa, [MaThuoc] = @MaThuoc, [SoLuong] = @SoLuong, [CachDung] = @CachDung WHERE [MaToa] = @MaToa";

            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaToa", cttt.MaToa);
                command.Parameters.AddWithValue("@MaThuoc", cttt.MaThuoc);
                command.Parameters.AddWithValue("@SoLuong", cttt.SoLuong);
                command.Parameters.AddWithValue("@CachDung", cttt.CachDung);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
