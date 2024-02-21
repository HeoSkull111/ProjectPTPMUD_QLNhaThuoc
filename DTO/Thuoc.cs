using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    internal class Thuoc
    {
        public Thuoc() { }
        public string MaThuoc {  get; set; }
        public string TenThuoc { get; set; }
        public string DonVi {  get; set; }
        public int? DonGia { get; set; }
        public DateTime? NSX { get; set; }
        public DateTime? HSD { get; set; }
    }
}
