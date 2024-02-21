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
    internal class HoaDonBUS
    {
        private HoaDonThuocDAO hoadonDAO;
        public HoaDonBUS()
        {
            hoadonDAO = new HoaDonThuocDAO();
        }
        public List<HoaDonThuoc> getAllHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = hoadonDAO.getAllHoaDonThuoc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<HoaDonThuoc> list = new List<HoaDonThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    HoaDonThuoc hoadon = new HoaDonThuoc();

                    hoadon.MaHD = dr["MaHD"].ToString();
                    hoadon.MaToa = dr["MaToa"].ToString();
                    hoadon.NgayBan = DateTime.Parse(dr["NgayBan"].ToString());
                    hoadon.TienThuoc = Int32.Parse(dr["TienThuoc"].ToString());
                    list.Add(hoadon);
                }
            }
            return list;
        }
        public List<HoaDonThuoc> getHDByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = hoadonDAO.getHoaDonThuocByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<HoaDonThuoc> list = new List<HoaDonThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    HoaDonThuoc hoadon = new HoaDonThuoc();

                    hoadon.MaHD = dr["MaHD"].ToString();
                    hoadon.MaToa = dr["MaToa"].ToString();
                    hoadon.NgayBan = DateTime.Parse(dr["NgayBan"].ToString());
                    hoadon.TienThuoc = Int32.Parse(dr["TienThuoc"].ToString());
                    list.Add(hoadon);
                }
            }
            return list;
        }
    }
}
