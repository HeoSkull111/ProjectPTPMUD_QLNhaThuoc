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
    internal class PhieuKhamBenhBUS
    {
        private PhieuKhamBenh_DAO PKBDAO;
        public PhieuKhamBenhBUS()
        {
            PKBDAO = new PhieuKhamBenh_DAO();
        }
        public List<PhieuKhamBenh> getAllPKB()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = PKBDAO.getAllPhieuKhamBenh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<PhieuKhamBenh> list = new List<PhieuKhamBenh>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    PhieuKhamBenh pkb = new PhieuKhamBenh();

                    pkb.MaPK = dr["MaPK"].ToString();
                    pkb.MaBN = dr["MaBN"].ToString();
                    pkb.NgayKham = DateTime.Parse(dr["NgayKham"].ToString());
                    pkb.STT = Int32.Parse(dr["STT"].ToString());
                    pkb.TrieuChung = dr["TrieuChung"].ToString();
                    pkb.ChuanDoan = dr["ChuanDoan"].ToString();
                    list.Add(pkb);
                }
            }
            return list;
        }
        public List<PhieuKhamBenh> getPKBByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = PKBDAO.getPhieuKhamBenhByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<PhieuKhamBenh> list = new List<PhieuKhamBenh>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    PhieuKhamBenh pkb = new PhieuKhamBenh();

                    pkb.MaPK = dr["MaPK"].ToString();
                    pkb.MaBN = dr["MaBN"].ToString();
                    pkb.NgayKham = DateTime.Parse(dr["NgayKham"].ToString());
                    pkb.STT = Int32.Parse(dr["STT"].ToString());
                    pkb.TrieuChung = dr["TrieuChung"].ToString();
                    pkb.ChuanDoan = dr["ChuanDoan"].ToString();
                    list.Add(pkb);
                }
            }
            return list;
        }
    }
}