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
    internal class ToaThuocBUS
    {
        private ToaThuocDAO ttDAO;
        public ToaThuocBUS()
        {
            ttDAO = new ToaThuocDAO();
        }
        public List<ToaThuoc> getAllTT()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ttDAO.getAllToaThuoc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ToaThuoc> list = new List<ToaThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ToaThuoc tt = new ToaThuoc();

                    tt.MaToa = dr["MaToa"].ToString();
                    tt.MaPK = dr["MaPK"].ToString();
                    tt.BacSiKeToa = dr["BacSiKeToa"].ToString();
                    tt.NgayKeToa = DateTime.Parse(dr["NgayKeToa"].ToString());
                    list.Add(tt);
                }
            }
            return list;
        }
        public void AddToaThuoc(ToaThuoc tt)
        {
            try
            {
                string maToa = tt.MaToa;
                string maPK = tt.MaPK;
                string bs = tt.BacSiKeToa;
                DateTime? NgaykeToa = tt.NgayKeToa;
                ttDAO.AddToaThuoc(tt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateToaThuoc(ToaThuoc tt)
        {
            try
            {
                string maToa = tt.MaToa;
                string maPK = tt.MaPK;
                string bs = tt.BacSiKeToa;
                DateTime? NgaykeToa = tt.NgayKeToa;
                ttDAO.UpdateToaThuoc(tt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteToaThuoc(string maToa)
        {
            ttDAO.DeleteToaThuoc(maToa);
        }
    }
}
