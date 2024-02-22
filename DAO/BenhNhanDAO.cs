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
    internal class BenhNhanDAO
    {
        public BenhNhanDAO() { }
        private string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLPhongKham;Integrated Security=True";

        public DataTable getAllBenhNhan()
        {
            DataTable dt = new DataTable();
            string query = "Select * from BenhNhan";
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
        public void AddHSBN(BenhNhan bn)
        {
            string q = "INSERT INTO BenhNhan ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) " +
                        "VALUES (@MaBN, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT)";
            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaBN", bn.MaBN);
                command.Parameters.AddWithValue("@HoTen", bn.HoTen);
                command.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                command.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                command.Parameters.AddWithValue("@SDT", bn.SDT);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteHSBN(string maBN)
        {
            try
            {
                string q = "DELETE FROM BenhNhan WHERE [MaBN] = @MaBN";

                using (SqlConnection connection = new SqlConnection(cons))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    command.Parameters.AddWithValue("@MaBN", maBN);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateHSBN(BenhNhan bn)
        {
            string q = "UPDATE BenhNhan SET [HoTen] = @HoTen, [GioiTinh] = @GioiTinh, [NgaySinh] = @NgaySinh, [DiaChi] = @DiaChi, [SDT] = @SDT WHERE [MaBN] = @MaBN";

            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaBN", bn.MaBN);
                command.Parameters.AddWithValue("@HoTen", bn.HoTen);
                command.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                command.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                command.Parameters.AddWithValue("@SDT", bn.SDT);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
