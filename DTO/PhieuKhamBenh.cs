using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    internal class PhieuKhamBenh
    {
        public PhieuKhamBenh() { } 
        public string MaPK { get; set; }
        public string MaBN { get; set; }
        public DateTime? NgayKham {  get; set; }
        public int? STT { get; set; }
        public string TrieuChung { get; set; }
        public string ChuanDoan { get; set; }
    }
}
