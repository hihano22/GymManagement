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
using GymManagement.DAO;
using GymManagement.DTO;

namespace GymManagement.GUI
{
    public partial class frmThemHoiVien : Form
    {
        public frmThemHoiVien()
        {
            InitializeComponent();
        }


        private void frmThemHoiVien_Load(object sender, EventArgs e)
        {
            txtThemHoiVien.Focus();
            txtThemHoiVien.Text = null;
            txtThemSDT.Text = null;
            lblNgayDKy.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }


        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            txtThemHoiVien.Text = null;
            txtThemSDT.Text = null;
            cboThemGioiTinh.Text = null;
            cboThemGoiTap.Text = null;  

        }

        private void btnLuuThemMoi_Click(object sender, EventArgs e)
        {
            string _tenHoiVien = txtThemHoiVien.Text;
            string _diaChi = txtThemDiaChi.Text;
            string _gioiTinh = cboThemGioiTinh.Text;
            string _goiTap = cboThemGoiTap.Text;
            int _sdt = Int32.Parse(txtThemSDT.Text);
            string _ngayDKy = DateTime.Now.ToString("yyyy-MM-dd");
            int _soNgayTap = Int32.Parse(cboSoNgayTap.Text);
            string _ngayHetHan = txtNgayHetHan.Text;
            HoiVien _hoiVien = new HoiVien(_tenHoiVien, _diaChi, _sdt, _soNgayTap, _ngayDKy, _ngayHetHan, _goiTap, _gioiTinh);
            HoiVienDAO.Instance.themHV(_hoiVien);
            
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void txtThemSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtThemSDT.Text) == false)
            {
                errorProvider1.SetError(txtThemSDT, "Nhập dữ liệu số!");
            }
            else if (txtThemSDT.Text.Length > 10)
            {
                errorProvider1.SetError(txtThemSDT, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
