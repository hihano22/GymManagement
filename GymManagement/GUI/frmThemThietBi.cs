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
    public partial class frmThemThietBi : Form
    {
        public frmThemThietBi()
        {
            InitializeComponent();
        }

        public void resetFormThem()
        {
            txtThemTenTB.Text = null;
            txtThemLoaiTB.Text = null;
            txtThemNNhapTB.Text = null;
            txtThemSoLuongTB.Text = null;
            txtThemDonGiaTB.Text = null;
            txtThemTLgTB.Text = null;
            txtHsxTB.Text = null;
            txtTTTB.Text = null;
        }

        private void btnLuuThemTB_Click(object sender, EventArgs e)
        {
            string _tenTb = txtThemTenTB.Text;
            string _loaiTb = txtThemLoaiTB.Text;
            string _ngayNhap = txtThemNNhapTB.Text;
            int _soLuong = Int32.Parse(txtThemSoLuongTB.Text);
            int _donGia = Int32.Parse(txtThemDonGiaTB.Text);
            double _trongLuong = Double.Parse(txtThemTLgTB.Text);
            string _hangSanXuat = txtHsxTB.Text;
            string _tinhTrang = txtTTTB.Text;

            ThietBi _thietBi = new ThietBi(_tenTb, _loaiTb, _ngayNhap, _soLuong, _donGia, _trongLuong, _hangSanXuat, _tinhTrang);
            ThietBiDAO.Instance.themThietBi(_thietBi);
        }

        private void btnXoaHetTB_Click(object sender, EventArgs e)
        {
            resetFormThem();
        }

        private void frmThemThietBi_Load(object sender, EventArgs e)
        {
            resetFormThem();
            txtThemTenTB.Focus();
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void txtThemSoLuongTB_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtThemSoLuongTB.Text) == false)
            {
                errorProvider1.SetError(txtThemSoLuongTB, "Nhập dữ liệu số!");
            }
            else if (txtThemSoLuongTB.Text.Length > 10)
            {
                errorProvider1.SetError(txtThemSoLuongTB, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
