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
    internal class BenhNhanBUS
    {
        private BenhNhanDAO benhNhanDAO;
        public BenhNhanBUS()
        {
            benhNhanDAO = new BenhNhanDAO();
        }
        public List<BenhNhan> getAllBenhNhan()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = benhNhanDAO.getAllBenhNhan();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<BenhNhan> list = new List<BenhNhan>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BenhNhan benhNhan = new BenhNhan();

                    benhNhan.MaBN = dr["MaBN"].ToString();
                    benhNhan.HoTen = dr["HoTen"].ToString();
                    benhNhan.GioiTinh = dr["GioiTinh"].ToString();
                    benhNhan.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                    benhNhan.DiaChi = dr["DiaChi"].ToString();
                    benhNhan.SDT = dr["SDT"].ToString();
                    list.Add(benhNhan);
                }
            }
            return list;
        }
        public void AddHSBN(BenhNhan bn)
        {
            try
            {
                string maBN = bn.MaBN;
                string HoTen = bn.HoTen;
                string gender = bn.GioiTinh;
                DateTime? NgaySinh = bn.NgaySinh;
                string address = bn.DiaChi;
                string SDT = bn.SDT;
                benhNhanDAO.AddHSBN(bn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateHSBN(BenhNhan bn)
        {
            try
            {
                string maBN = bn.MaBN;
                string HoTen = bn.HoTen;
                string gender = bn.GioiTinh;
                DateTime? NgaySinh = bn.NgaySinh;
                string address = bn.DiaChi;
                string SDT = bn.SDT;
                benhNhanDAO.UpdateHSBN(bn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteHSBN(string maBN)
        {
            benhNhanDAO.DeleteHSBN(maBN);
        }
    }
}
