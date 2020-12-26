using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Receipt
    {
        public string MaHD { get; set; }
        public string StringThoiGian { get; set; }
        public string MaKH { get; set; }
        public string TenNV { get; set; }
        public string StringTongThanhToan { get; set; }
        public string StringTienKhachDua { get; set; }
        public string StringTraLaiKhach { get; set; }
    }

    public class SanPhamThanhToan
    {
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
    }
}
