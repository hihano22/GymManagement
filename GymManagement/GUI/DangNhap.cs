using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;

            if (tentk.Trim() == "") { MessageBox.Show("Không được để trống! Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Không được để trống! Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!"/*, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information*/);

                    //Ẩn form Đăng nhập và chuyển sang FormMain
                    this.Hide();
                    frmMain toMain = new frmMain();
                    toMain.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!"/*, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information*/);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();   
            dangKy.ShowDialog();
        }
    }
}
