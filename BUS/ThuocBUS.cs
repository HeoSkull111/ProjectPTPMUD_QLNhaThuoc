using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Thuoc> getThuocByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = thuocDAO.getToaThuocByID(id);
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
    }
}
