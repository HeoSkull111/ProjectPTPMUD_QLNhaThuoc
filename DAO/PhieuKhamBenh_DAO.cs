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
    internal class PhieuKhamBenh_DAO
    {
        public PhieuKhamBenh_DAO() { }
        private string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLPhongKham;Integrated Security=True";
        public DataTable getAllPhieuKhamBenh()
        {
            DataTable dt = new DataTable();
            string query = "Select * from PhieuKham";
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
        public void AddPKB(PhieuKhamBenh phieuKham)
        {
            string q = "INSERT INTO PhieuKham ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) " +
                        "VALUES (@MaPK, @MaBN, @NgayKham, @STT, @TrieuChung, @ChuanDoan)";
            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@MaPK", phieuKham.MaPK);
                command.Parameters.AddWithValue("@MaBN", phieuKham.MaBN);
                command.Parameters.AddWithValue("@NgayKham", phieuKham.NgayKham);
                command.Parameters.AddWithValue("@STT", phieuKham.STT);
                command.Parameters.AddWithValue("@TrieuChung", phieuKham.TrieuChung);
                command.Parameters.AddWithValue("@ChuanDoan", phieuKham.ChuanDoan);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeletePKB(string maPK)
        {
            try
            {
                string q = "DELETE FROM PhieuKham WHERE [MaPK] = @MaPK";

                using (SqlConnection connection = new SqlConnection(cons))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    command.Parameters.AddWithValue("@MaPK", maPK);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdatePKB(PhieuKhamBenh phieuKham)
        {
            string q = "UPDATE PhieuKham SET [NgayKham] = @NgayKham, [STT] = @STT, [TrieuChung] = @TrieuChung, [ChuanDoan] = @ChuanDoan WHERE [MaPK] = @MaPK";

            using (SqlConnection connection = new SqlConnection(cons))
            {
                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@NgayKham", phieuKham.NgayKham);
                command.Parameters.AddWithValue("@STT", phieuKham.STT);
                command.Parameters.AddWithValue("@TrieuChung", phieuKham.TrieuChung);
                command.Parameters.AddWithValue("@ChuanDoan", phieuKham.ChuanDoan);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
