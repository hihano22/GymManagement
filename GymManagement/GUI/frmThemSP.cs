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
    public partial class frmThemSP : Form
    {
        public frmThemSP()
        {
            InitializeComponent();
        }

        public void resetFormThem()
        {
            txtThemTenSP.Text = null;
            txtThemLoaiSp.Text = null;
            txtThemNNhap.Text = null;
            txtThemSoLuong.Text = null;
            txtThemDonGia.Text = null;
            txtThemTLg.Text = null;
            txtHsx.Text = null;
            txtTT.Text = null;
        }


        private void frmThemSP_Load(object sender, EventArgs e)
        {
            resetFormThem();
            txtThemTenSP.Focus();
        }

        private void btnLuuThemSP_Click(object sender, EventArgs e)
        {
            string _tenSp = txtThemTenSP.Text;
            string _loaiSp = txtThemLoaiSp.Text;   
            string _ngayNhap = txtThemNNhap.Text;
            int _soLuong = Int32.Parse(txtThemSoLuong.Text);
            int _donGia = Int32.Parse(txtThemDonGia.Text);
            double _trongLuong = Double.Parse(txtThemTLg.Text);
            string _hangSanXuat = txtHsx.Text;
            string _tinhTrang = txtTT.Text;

            SanPham _sanPham = new SanPham(_tenSp, _loaiSp, _ngayNhap, _soLuong, _donGia, _trongLuong, _hangSanXuat, _tinhTrang);  
            SanPhamDAO.Instance.themSanPham(_sanPham);
            
        }

        private void btnXoaHetSp_Click(object sender, EventArgs e)
        {
            resetFormThem();
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void txtThemSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtThemSoLuong.Text) == false)
            {
                errorProvider1.SetError(txtThemSoLuong, "Nhập dữ liệu số!");
            }
            else if (txtThemSoLuong.Text.Length > 10)
            {
                errorProvider1.SetError(txtThemSoLuong, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
