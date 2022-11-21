using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;


        public TaiKhoan()//khoi tao constructor 0 chua tham so
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)//khoi tao constructor chua tham so
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
