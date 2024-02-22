using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.BUS
{
    internal class ThuocBUS
    {
        private ThuocDAO thuocDAO;
        public ThuocBUS()
        {
            thuocDAO = new ThuocDAO();
        }
        public List<Thuoc> getAllThuoc()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = thuocDAO.getAllThuoc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<Thuoc> list = new List<Thuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Thuoc thuoc = new Thuoc();

                    thuoc.MaThuoc = dr["MaThuoc"].ToString();
                    thuoc.TenThuoc = dr["TenThuoc"].ToString();
                    thuoc.DonVi = dr["DonVi"].ToString();
                    thuoc.DonGia = Int32.Parse(dr["DonGia"].ToString());
                    thuoc.NSX = DateTime.Parse(dr["NSX"].ToString());
                    thuoc.HSD = DateTime.Parse(dr["HSD"].ToString());
                    list.Add(thuoc);
                }
            }
            return list;
        }

        public void AddThuoc(Thuoc thuoc)
        {
            try
            {
                string maThuoc = thuoc.MaThuoc;
                string tenThuoc = thuoc.TenThuoc;
                string donVi = thuoc.DonVi;
                int? donGia = thuoc.DonGia;
                DateTime? nsx = thuoc.NSX;
                DateTime? hsd = thuoc.HSD;
                thuocDAO.AddThuoc(thuoc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateThuoc(Thuoc thuoc)
        {
            try
            {
                string maThuoc = thuoc.MaThuoc;
                string tenThuoc = thuoc.TenThuoc;
                string donVi = thuoc.DonVi;
                int? donGia = thuoc.DonGia;
                DateTime? nsx = thuoc.NSX;
                DateTime? hsd = thuoc.HSD;
                thuocDAO.UpdateThuoc(thuoc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteThuoc(string maThuoc)
        {
            thuocDAO.DeleteThuoc(maThuoc);
        }
    }
}
