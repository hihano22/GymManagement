using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DTO
{
    public class SanPham
    {
        public int maSp { get; set; } 
        public string tenSp { get; set; }
        public string loaiSp {get; set; } 
        public string ngayNhap { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public double trongLuong { get; set; }
        public string hsx { get; set; }
        public string tinhTrang { get; set; }

        
        public SanPham(string tenSp, string loaiSp, string ngayNhap, int soLuong, int donGia, double trongLuong, string hsx, string tinhTrang)
        {
            this.tenSp = tenSp;
            this.loaiSp = loaiSp;
            this.ngayNhap = ngayNhap;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.trongLuong = trongLuong;
            this.hsx = hsx;
            this.tinhTrang = tinhTrang;
        }
        public SanPham(string tenSp, string loaiSp, int soLuong, string hsx, string tinhTrang)
        {
            this.tenSp = tenSp;
            this.loaiSp = loaiSp;
            this.soLuong = soLuong;
            this.hsx = hsx;
            this.tinhTrang = tinhTrang;
        }
    }
}
