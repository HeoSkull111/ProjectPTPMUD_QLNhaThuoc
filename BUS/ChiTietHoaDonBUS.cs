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
    internal class ChiTietHoaDonBUS
    {
        private ChiTietHD_DAO cthdDAO;
        public ChiTietHoaDonBUS()
        {
            cthdDAO = new ChiTietHD_DAO();
        }
        public List <ChiTietHD> getAllCTHD()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cthdDAO.getAllChiTietHD();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ChiTietHD> list = new List<ChiTietHD>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ChiTietHD cthd = new ChiTietHD();

                    cthd.MaHD = dr["MaHD"].ToString();
                    cthd.MaToa = dr["MaToa"].ToString();
                    cthd.SoLuong = Int32.Parse(dr["SoLuong"].ToString());
                    cthd.DonGia = Int32.Parse(dr["DonGia"].ToString());
                    cthd.ID_CTTT = dr["ID_CTTT"].ToString();
                    list.Add(cthd);
                }
            }
            return list;
        }
        public List<ChiTietHD> getCTTTByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cthdDAO.getChiTietHDByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ChiTietHD> list = new List<ChiTietHD>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ChiTietHD cthd = new ChiTietHD();

                    cthd.MaHD = dr["MaHD"].ToString();
                    cthd.MaToa = dr["MaToa"].ToString();
                    cthd.SoLuong = Int32.Parse(dr["SoLuong"].ToString());
                    cthd.DonGia = Int32.Parse(dr["DonGia"].ToString());
                    cthd.ID_CTTT = dr["ID_CTTT"].ToString();
                    list.Add(cthd);
                }
            }
            return list;
        }
    }
}
