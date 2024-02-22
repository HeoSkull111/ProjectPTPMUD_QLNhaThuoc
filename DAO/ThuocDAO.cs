using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DTO;

namespace Project.DAO
{
    internal class ThuocDAO
    {
        public ThuocDAO() { }
        private string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLPhongKham;Integrated Security=True";
        public DataTable getAllThuoc()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Thuoc";
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
        public void AddThuoc(Thuoc thuoc)
        {
            string q = "INSERT INTO Thuoc ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NSX], [HSD]) " +
                        "VALUES (@MaThuoc, @TenThuoc, @DonVi, @DonGia, @NSX, @HSD)";
            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaThuoc", thuoc.MaThuoc);
                command.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                command.Parameters.AddWithValue("@DonVi", thuoc.DonVi);
                command.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                command.Parameters.AddWithValue("@NSX", thuoc.NSX);
                command.Parameters.AddWithValue("@HSD", thuoc.HSD);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteThuoc(string MaThuoc)
        {
            try
            { 
                string q = "DELETE FROM Thuoc WHERE [MaThuoc] = @MaThuoc";

                using (SqlConnection connection = new SqlConnection(cons))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    command.Parameters.AddWithValue("@MaThuoc", MaThuoc);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateThuoc(Thuoc thuoc)
        {
            // Tạo câu lệnh SQL cập nhật thông tin
            string q = "UPDATE Thuoc SET [TenThuoc] = @TenThuoc, [DonVi] = @DonVi, [DonGia] = @DonGia, [NSX] = @NSX, [HSD] = @HSD WHERE [MaThuoc] = @MaThuoc";

            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaThuoc", thuoc.MaThuoc);
                command.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                command.Parameters.AddWithValue("@DonVi", thuoc.DonVi);
                command.Parameters.AddWithValue("@DonGia",thuoc.DonGia);
                command.Parameters.AddWithValue("@NSX", thuoc.NSX);
                command.Parameters.AddWithValue("@HSD", thuoc.HSD);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
