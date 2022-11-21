using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DTO
{
    public class ThietBi
    {
        public int maTb { get; set; }
        public string tenTb { get; set; }
        public string loaiTb { get; set; }
        public string ngayNhap { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public double trongLuong { get; set; }
        public string hsx { get; set; }
        public string tinhTrang { get; set; }


        public ThietBi(string tenTb, string loaiTb, string ngayNhap, int soLuong, int donGia, double trongLuong, string hsx, string tinhTrang)
        {
            this.tenTb = tenTb;
            this.loaiTb = loaiTb;
            this.ngayNhap = ngayNhap;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.trongLuong = trongLuong;
            this.hsx = hsx;
            this.tinhTrang = tinhTrang;
        }
        public ThietBi(string tenTb, string loaiTb, int soLuong, string hsx, string tinhTrang)
        {
            this.tenTb = tenTb;
            this.loaiTb = loaiTb;
            this.soLuong = soLuong;
            this.hsx = hsx;
            this.tinhTrang = tinhTrang;
        }
    }
}
