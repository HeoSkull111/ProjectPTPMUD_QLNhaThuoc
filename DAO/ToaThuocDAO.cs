using Project.DTO;
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
        private string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLPhongKham;Integrated Security=True";
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
        public void AddToaThuoc(ToaThuoc tt)
        {
            string q = "INSERT INTO ToaThuoc ([MaToa], [MaPK], [BacSiKeToa], [NgayKeToa]) " +
                        "VALUES (@MaToa, @MaPK, @BacSiKeToa, @NgayKeToa)";
            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaToa", tt.MaToa);
                command.Parameters.AddWithValue("@MaPK", tt.MaPK);
                command.Parameters.AddWithValue("@BacSiKeToa", tt.BacSiKeToa);
                command.Parameters.AddWithValue("@NgayKeToa", tt.NgayKeToa);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteToaThuoc(string maToa)
        {
            try
            {
                string q = "DELETE FROM ToaThuoc WHERE [MaToa] = @MaToa";

                using (SqlConnection connection = new SqlConnection(cons))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    command.Parameters.AddWithValue("@MaToa", maToa);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateToaThuoc(ToaThuoc tt)
        {
            string q = "UPDATE ToaThuoc SET [MaToa] = @MaToa, [MaPK] = @MaPK, [BacSiKeToa] = @BacSiKeToa, [NgayKeToa] = @NgayKeToa WHERE [MaToa] = @MaToa";

            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaToa", tt.MaToa);
                command.Parameters.AddWithValue("@MaPK", tt.MaPK);
                command.Parameters.AddWithValue("@BacSiKeToa", tt.BacSiKeToa);
                command.Parameters.AddWithValue("@NgayKeToa", tt.NgayKeToa);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
