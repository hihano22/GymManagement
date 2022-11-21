using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.DTO;

namespace GymManagement.DAO
{
    internal class SanPhamDAO
    {
        private const string connectionStr = @"Data Source=DESKTOP-DCI7V8V\SQLEXPRESS;Initial Catalog = gym1; Integrated Security = True";

        private static SanPhamDAO? instance;

        public static SanPhamDAO Instance
        { get { return instance ?? (instance = new SanPhamDAO()); } }

        private SanPhamDAO() { }


        public DataTable loadDataSP()
        {
            string query = "SELECT MASP AS [Mã sản phẩm], " +
                "TEN AS [Tên sản phẩm], " +
                "LOAI AS [Loại sản phẩm], " +
                "NGAYNHAP AS [Ngày nhập], " +
                "SOLUONG AS [Số lượng], " +
                "DONGIA AS [Đơn giá], " +
                "TRONGLUONG AS [Trọng lượng], " +
                "HANGSANXUAT AS [Hãng sản xuất], " +
                "TINHTRANG AS [Tình trạng] " +
                "FROM SANPHAM";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public void themSanPham(SanPham _sanPham)
        {
            string query = "INSERT INTO SANPHAM " +
                "(TEN, LOAI, NGAYNHAP, SOLUONG, DONGIA, TRONGLUONG, HANGSANXUAT, TINHTRANG)" +
                "VALUES(@TEN, @LOAI, @NGAYNHAP, @SOLUONG, @DONGIA, @TRONGLUONG, @HANGSANXUAT, @TINHTRANG)";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@TEN", _sanPham.tenSp);
                cmd.Parameters.AddWithValue("@LOAI", _sanPham.loaiSp);
                cmd.Parameters.AddWithValue("@NGAYNHAP", _sanPham.ngayNhap);
                cmd.Parameters.AddWithValue("@SOLUONG", _sanPham.soLuong);
                cmd.Parameters.AddWithValue("@DONGIA", _sanPham.donGia);
                cmd.Parameters.AddWithValue("@TRONGLUONG", _sanPham.trongLuong);
                cmd.Parameters.AddWithValue("@HANGSANXUAT", _sanPham.hsx);
                cmd.Parameters.AddWithValue("@TINHTRANG", _sanPham.tinhTrang);
              
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi thêm sản phẩm!");
                }
                connection.Close();
            }
        }

        public void suaSanPham(int _maSp, SanPham _sanPham)
        {
            string query = "UPDATE SANPHAM SET TEN = @TEN, " +
                " LOAI = @LOAI," +
                " SOLUONG = @SOLUONG, " +
                "HANGSANXUAT = @HANGSANXUAT, " +
                "TINHTRANG = @TINHTRANG " +
                "WHERE MASP = @MASP";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MASP", _maSp);
                cmd.Parameters.AddWithValue("@TEN", _sanPham.tenSp);
                cmd.Parameters.AddWithValue("@LOAI", _sanPham.loaiSp);
                cmd.Parameters.AddWithValue("@SOLUONG", _sanPham.soLuong);
                cmd.Parameters.AddWithValue("@HANGSANXUAT", _sanPham.hsx);
                cmd.Parameters.AddWithValue("@TINHTRANG", _sanPham.tinhTrang);
             
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật!");
                }
                connection.Close();
            }
        }

        public void xoaSanPham(int _maSp)
        {
            string query = "DELETE FROM SANPHAM WHERE MASP = @MASP";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MASP", _maSp);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi xóa!");
                }
                connection.Close();
            }
        }

        public DataTable timSanPham(string _search)
        {
            string query = "SELECT * FROM SANPHAM WHERE TEN LIKE N'%" + _search + "%'";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


    }
}
