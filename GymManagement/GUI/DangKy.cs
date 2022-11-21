using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        public void ReturnDN() //quay lai FormDangNhap
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
        public bool CheckAccountExist(string ace)//check tai khoan va mat khau
        {
            return Regex.IsMatch(ace, "^[a-zA-Z0-9]{6,24}$");//a==>z, A==>Z, 0==>9, so luong ki tu trong khoang 6,24
        }

        public bool CheckEmail(string ckEmail)
        {
            return Regex.IsMatch(ckEmail, @"^[\w.]{3,26}@gmail.com");
            //Dinh dang email ***@gmail.com
        }

        Modify modify = new Modify();
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            if (!CheckAccountExist(tentk))
            {
                MessageBox.Show("Vui lòng nhập trong khoảng 6-24 ký tự, phân biệt chữ hoa và chữ thường!");
                return;
            }

            if (!CheckAccountExist(matkhau))
            {
                MessageBox.Show("Vui lòng nhập trong khoảng 6-24 ký tự, phân biệt chữ hoa và chữ thường!");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu vừa nhập!");
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!");
                return;
            }

            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng chọn email khác!");
                return;
            }

            //Xu ly su kien Insert
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);

                //Hien thi khi dang ky thanh cong
                if (MessageBox.Show("Đã đăng ký thành công! Bạn có muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes) //Hien thi hop thong bao tuy chon
                {
                    //quay lai FormDangNhap
                    ReturnDN();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã có, vui lòng chọn tên tài khoản khác!");
            }

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_TroLaiDN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnDN();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
