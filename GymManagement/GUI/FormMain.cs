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
using System.Windows.Forms.VisualStyles;
using GymManagement.DAO;
using GymManagement.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagement.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region init Hoi vien
            btnSuaHoiVien.Enabled = false;
            btnGiaHan.Enabled = false;
            btnLuuHoiVien.Enabled = false;
            btnXoaHoiVien.Enabled = false;

            dgvHoiVien.DataSource = HoiVienDAO.Instance.loadDataHV();
            #endregion

            #region init San pham
            btnSuaSp.Enabled = false;
            btnXoaSp.Enabled = false;
            dgvSP.DataSource = SanPhamDAO.Instance.loadDataSP();
            #endregion

            #region init Thiet bi
            btnSuaTB.Enabled = false;
            btnXoaTB.Enabled = false;
            dgvTB.DataSource = ThietBiDAO.Instance.loadDataTB();
            #endregion
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        #region Hoi vien

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSdt.Text) == false)
            {
                errorProvider1.SetError(txtSdt, "Nhập dữ liệu số!");
            }
            else if (txtSdt.Text.Length > 10)
            {
                errorProvider1.SetError(txtSdt, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnThemHoiVien_Click(object sender, EventArgs e)
        {
            frmThemHoiVien frmThemHoiVien = new frmThemHoiVien();
            frmThemHoiVien.ShowDialog();
            dgvHoiVien.DataSource = HoiVienDAO.Instance.loadDataHV();
        }

        private void btnLuuHoiVien_Click(object sender, EventArgs e)
        {
            int _maHoiVien = Int32.Parse(txtMaHoiVien.Text);
            string _tenHoiVien = txtHoTen.Text;
            string _gioiTinh = cboGioiTinhMain.Text;
            string _goiTap = cboGoiTapMain.Text;
            int _sdt = Int32.Parse(txtSdt.Text);
            HoiVien _hoiVien = new HoiVien(_tenHoiVien, _sdt, _goiTap, _gioiTinh);
            HoiVienDAO.Instance.suaHV(_maHoiVien, _hoiVien);
            dgvHoiVien.DataSource = HoiVienDAO.Instance.loadDataHV();

        }

        private void btnSuaHoiVien_Click(object sender, EventArgs e)
        {
            int _maHoiVien = Int32.Parse(txtMaHoiVien.Text);
            string _tenHoiVien = txtHoTen.Text;
            string _gioiTinh = cboGioiTinhMain.Text;
            string _goiTap = cboGoiTapMain.Text;
            int _sdt = Int32.Parse(txtSdt.Text);
            HoiVien _hoiVien = new HoiVien(_tenHoiVien, _sdt, _goiTap, _gioiTinh);
            HoiVienDAO.Instance.suaHV(_maHoiVien, _hoiVien);
            dgvHoiVien.DataSource = HoiVienDAO.Instance.loadDataHV();
        }

        private void btnSearchHoiVien_Click_1(object sender, EventArgs e)
        {
            string _tenHoiVien = txtSearchHoiVien.Text;
            dgvHoiVien.DataSource = HoiVienDAO.Instance.timHV(_tenHoiVien);
        }

        private void dgvHoiVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaHoiVien.Enabled = true;
            btnGiaHan.Enabled = true;
            btnLuuHoiVien.Enabled = true;
            btnXoaHoiVien.Enabled = true;
            txtMaHoiVien.Text = dgvHoiVien.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            txtHoTen.Text = dgvHoiVien.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            cboGioiTinhMain.Text = dgvHoiVien.Rows[e.RowIndex].Cells[8].Value.ToString(); 
            cboGoiTapMain.Text = dgvHoiVien.Rows[e.RowIndex].Cells[7].Value.ToString(); 
            txtSdt.Text = dgvHoiVien.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            lblHanTap.Text = dgvHoiVien.Rows[e.RowIndex].Cells[6].Value.ToString(); 
            
        }

        private void btnXoaHoiVien_Click(object sender, EventArgs e)
        {
            int _maHoiVien = Int32.Parse(txtMaHoiVien.Text);
            HoiVienDAO.Instance.xoaHV(_maHoiVien);
            dgvHoiVien.DataSource = HoiVienDAO.Instance.loadDataHV();
            txtMaHoiVien.Text = null;
            txtHoTen.Text = null;
            cboGioiTinhMain.Text = null;
            cboGoiTapMain.Text = null;
            txtSdt.Text = null;
            lblHanTap.Text = null;
        }
        #endregion

        #region San pham

        private void txtSoLuongSp_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSoLuongSp.Text) == false)
            {
                errorProvider1.SetError(txtSoLuongSp, "Nhập dữ liệu số!");
            }
            else if (txtSoLuongSp.Text.Length > 10)
            {
                errorProvider1.SetError(txtSoLuongSp, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void btnThemSp_Click(object sender, EventArgs e)
        {
            frmThemSP frmThemSP = new frmThemSP();
            frmThemSP.ShowDialog();
            dgvSP.DataSource = SanPhamDAO.Instance.loadDataSP();
        }

        private void btnSuaSp_Click(object sender, EventArgs e)
        {
            int _maSp = Int32.Parse(txtMaSp.Text);
            string _tenSp = txtTenSp.Text;
            string _loaiSp = txtLoaiSp.Text;
            int _soLuong = Int32.Parse(txtSoLuongSp.Text);
            string _hangSanXuat = txtHSX.Text;
            string _tinhTrang = txtTT.Text;

            SanPham _sanPham = new SanPham(_tenSp, _loaiSp, _soLuong, _hangSanXuat, _tinhTrang);
            SanPhamDAO.Instance.suaSanPham(_maSp, _sanPham);
            dgvSP.DataSource = SanPhamDAO.Instance.loadDataSP();
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            int _maSp = Int32.Parse(txtMaSp.Text);
            SanPhamDAO.Instance.xoaSanPham(_maSp);
            dgvSP.DataSource = SanPhamDAO.Instance.loadDataSP();
            txtMaSp.Text = null;
            txtTenSp.Text = null;
            txtLoaiSp.Text = null;
            txtSoLuongSp.Text = null;
            txtHSX.Text = null;
            txtTT.Text = null;
        }

        private void btnSearchSp_Click(object sender, EventArgs e)
        {
            string _search = txtSearchSp.Text;
            dgvSP.DataSource = SanPhamDAO.Instance.timSanPham(_search);
        }
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaSp.Enabled = true;
            btnXoaSp.Enabled = true;
            txtMaSp.Text = dgvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSp.Text = dgvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLoaiSp.Text = dgvSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuongSp.Text = dgvSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtHSX.Text = dgvSP.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTT.Text = dgvSP.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        #endregion

        #region Thiet bi

        private void txtSluongTB_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSluongTB.Text) == false)
            {
                errorProvider1.SetError(txtSluongTB, "Nhập dữ liệu số!");
            }
            else if (txtSluongTB.Text.Length > 10)
            {
                errorProvider1.SetError(txtSluongTB, "Độ dài < 10");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void btnThemTB_Click(object sender, EventArgs e)
        {
            frmThemThietBi frmThemThietBi = new frmThemThietBi();
            frmThemThietBi.ShowDialog();
            dgvTB.DataSource = ThietBiDAO.Instance.loadDataTB();
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            int _maTb = Int32.Parse(txtMaTB.Text);
            string _tenTb = txtTenTB.Text;
            string _loaiTb = txtLoaiTB.Text;
            int _soLuong = Int32.Parse(txtSluongTB.Text);
            string _hangSanXuat = txtHsxTb.Text;
            string _tinhTrang = txtTTTB.Text;

            ThietBi _thietBi = new ThietBi(_tenTb, _loaiTb, _soLuong, _hangSanXuat, _tinhTrang);
            ThietBiDAO.Instance.suaThietBi(_maTb, _thietBi);
            dgvTB.DataSource = ThietBiDAO.Instance.loadDataTB();
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            int _maTb = Int32.Parse(txtMaTB.Text);
            ThietBiDAO.Instance.xoaThietBi(_maTb);
            dgvTB.DataSource = ThietBiDAO.Instance.loadDataTB();
            txtMaTB.Text = null;
            txtTenTB.Text = null;
            txtLoaiTB.Text = null;
            txtSluongTB.Text = null;
            txtHsxTb.Text = null;
            txtTTTB.Text = null;
        }

        private void btnSearchTB_Click(object sender, EventArgs e)
        {
            string _search = txtSearchTB.Text;
            dgvTB.DataSource = ThietBiDAO.Instance.timThietBi(_search);
        }

        private void dgvTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaTB.Enabled = true;
            btnXoaTB.Enabled = true;
            txtMaTB.Text = dgvTB.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenTB.Text = dgvTB.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLoaiTB.Text = dgvTB.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSluongTB.Text = dgvTB.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtHsxTb.Text = dgvTB.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTTTB.Text = dgvTB.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();//hien thi man hinh Dang nhap
            this.Close();
        }
    }
}
