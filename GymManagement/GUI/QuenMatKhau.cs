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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void ReturnDN() //quay lai FormDangNhap
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đã được đăng ký!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label_KetQua.ForeColor = Color.Green;
                    label_KetQua.Text = "Tài khoản: "
                                        + modify.TaiKhoans(query)[0].TenTaiKhoan
                                        + "Mật khẩu: "
                                        + modify.TaiKhoans(query)[0].MatKhau;

                    //Tuy chon dang nhap
                    if (MessageBox.Show("Bạn có muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes) //Hien thi hop thong bao tuy chon
                    {
                        //quay lai FormDangNhap
                        ReturnDN();
                    }
                }
                else
                {
                    label_KetQua.ForeColor = Color.Red;
                    label_KetQua.Text = "Email chưa được đăng ký! ";
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnDN();
        }
    }
}
