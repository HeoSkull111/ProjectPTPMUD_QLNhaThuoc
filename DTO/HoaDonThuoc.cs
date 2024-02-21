using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    internal class HoaDonThuoc
    {
        public HoaDonThuoc() { }
        public string MaHD {  get; set; }
        public string MaToa {  get; set; }
        public DateTime? NgayBan { get; set; }
        public int? TienThuoc {  get; set; }
    }
}
