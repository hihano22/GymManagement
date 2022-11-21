using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DTO
{
    public class HoiVien
    {
        public int maHocVien { get; set; }  
        public string tenHocVien { get; set; }  
        public string diaChi { get; set; }  
        public int sdt { get; set; }    
        public int soNgayTap { get; set; }  
        public string ngayDangKy { get; set; }    
        public string ngayHetHan { get; set; }    
        public string goiTap { get; set; }  
        public string gioiTinh { get; set; }

        public HoiVien() { }
        public HoiVien(string tenHocVien, string diaChi, int sdt, int soNgayTap, string ngayDangKy, string ngayHetHan, string goiTap, string gioiTinh)
        {
            this.tenHocVien = tenHocVien;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.soNgayTap = soNgayTap;
            this.ngayDangKy = ngayDangKy;
            this.ngayHetHan = ngayHetHan;
            this.goiTap = goiTap;
            this.gioiTinh = gioiTinh;
        }

        public HoiVien(string tenHocVien, int sdt, string goiTap, string gioiTinh)
        {
            this.tenHocVien = tenHocVien;
            this.sdt = sdt;
            this.goiTap = goiTap;
            this.gioiTinh = gioiTinh;
        }
    }
}
