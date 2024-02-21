﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    internal class HoaDonThuocDAO
    {
        public HoaDonThuocDAO() { }
        public DataTable getAllHoaDonThuoc()
        {
            DataTable dt = new DataTable();
            string query = "Select * from HoaDonThuoc";
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
        public DataTable getHoaDonThuocByID(int _id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from HoaDonThuoc where MaHD = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int)
            {
                Value = _id
            };
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
