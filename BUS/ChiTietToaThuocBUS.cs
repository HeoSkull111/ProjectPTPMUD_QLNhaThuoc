﻿using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BUS
{
    internal class ChiTietToaThuocBUS
    {
        private ChiTietToaThuocDAO ctttDAO;
        public ChiTietToaThuocBUS()
        {
            ctttDAO = new ChiTietToaThuocDAO();
        }
        public List<ChiTietToaThuoc> getAllCTTT()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ctttDAO.getAllChiTietToaThuoc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ChiTietToaThuoc> list = new List<ChiTietToaThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ChiTietToaThuoc cttt = new ChiTietToaThuoc();

                    cttt.MaToa = dr["MaToa"].ToString();
                    cttt.MaThuoc = dr["MaThuoc"].ToString();
                    cttt.SoLuong = dr["SoLuong"].ToString();
                    cttt.CachDung = dr["CachDung"].ToString();
                    list.Add(cttt);
                }
            }
            return list;
        }
        public List<ChiTietToaThuoc> getCTTTByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ctttDAO.getChiTietToaThuocByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ChiTietToaThuoc> list = new List<ChiTietToaThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ChiTietToaThuoc cttt = new ChiTietToaThuoc();

                    cttt.MaToa = dr["MaToa"].ToString();
                    cttt.MaThuoc = dr["MaThuoc"].ToString();
                    cttt.SoLuong = dr["SoLuong"].ToString();
                    cttt.CachDung = dr["CachDung"].ToString();
                    list.Add(cttt);
                }
            }
            return list;
        }
    }
}
