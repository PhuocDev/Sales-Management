using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class ClassSanPham
    {
        public string maSP;
        public string tenSP;
		public int soLuong;
		public string donViTinh;
		public int giaNhap;
		public int giaBan;
		public DateTime hanSuDung;
		public string nhaCungCap;
		public string ghiChu;
		public ClassSanPham() { }
		public ClassSanPham(string maSP, string tenSP, int soLuong, string donViTinh, int giaNhap, int giaBan, DateTime hanSuDung, string nhaCungCap, string ghiChu)
		{
			this.maSP = maSP;
			this.tenSP = tenSP;
			this.soLuong = soLuong;
			this.donViTinh = donViTinh;
			this.giaNhap = giaNhap;
			this.giaBan = giaBan;
			this.hanSuDung = hanSuDung;
			this.nhaCungCap = nhaCungCap;
			this.ghiChu = ghiChu;
		}

/*	MASP VARCHAR(20) NOT NULL,
	TEN NVARCHAR(100),
	SOLUONG INT,
	DVT NVARCHAR(50),
	GIANHAP INT,
	GIABANLE INT,
	HSD SMALLDATETIME,
	NHACUNGCAP NVARCHAR(100),
	GHICHU NVARCHAR(100),*/
    }
}
