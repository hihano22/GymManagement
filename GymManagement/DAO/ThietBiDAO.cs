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
    internal class ThietBiDAO
    {
        private const string connectionStr = @"Data Source=DESKTOP-DCI7V8V\SQLEXPRESS;Initial Catalog = gym1; Integrated Security = True";

        private static ThietBiDAO? instance;

        public static ThietBiDAO Instance
        { get { return instance ?? (instance = new ThietBiDAO()); } }

        private ThietBiDAO() { }


        public DataTable loadDataTB()
        {
            string query = "SELECT MATB AS [Mã thiết bị], " +
                "TENTB AS [Tên thiết bị], " +
                "LOAITB AS [Loại thiết bị], " +
                "NGAYNHAP AS [Ngày nhập], " +
                "SOLUONG AS [Số lượng], " +
                "DONGIA AS [Đơn giá], " +
                "TRONGLUONG AS [Trọng lượng], " +
                "HANGSANXUAT AS [Hãng sản xuất], " +
                "TINHTRANG AS [Tình trạng] " +
                "FROM THIETBI";
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

        public void themThietBi(ThietBi _thietBi)
        {
            string query = "INSERT INTO THIETBI " +
                "(TENTB, LOAITB, NGAYNHAP, SOLUONG, DONGIA, TRONGLUONG, HANGSANXUAT, TINHTRANG)" +
                "VALUES(@TENTB, @LOAITB, @NGAYNHAP, @SOLUONG, @DONGIA, @TRONGLUONG, @HANGSANXUAT, @TINHTRANG)";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@TENTB", _thietBi.tenTb);
                cmd.Parameters.AddWithValue("@LOAITB", _thietBi.loaiTb);
                cmd.Parameters.AddWithValue("@NGAYNHAP", _thietBi.ngayNhap);
                cmd.Parameters.AddWithValue("@SOLUONG", _thietBi.soLuong);
                cmd.Parameters.AddWithValue("@DONGIA", _thietBi.donGia);
                cmd.Parameters.AddWithValue("@TRONGLUONG", _thietBi.trongLuong);
                cmd.Parameters.AddWithValue("@HANGSANXUAT", _thietBi.hsx);
                cmd.Parameters.AddWithValue("@TINHTRANG", _thietBi.tinhTrang);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Thêm thiết bị thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi thêm thiết bị!");
                }
                connection.Close();
            }
        }

        public void suaThietBi(int _maTB, ThietBi _thietBi)
        {
            string query = "UPDATE THIETBI SET TENTB = @TENTB, " +
                " LOAITB = @LOAITB," +
                " SOLUONG = @SOLUONG, " +
                "HANGSANXUAT = @HANGSANXUAT, " +
                "TINHTRANG = @TINHTRANG " +
                "WHERE MATB = @MATB";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MATB", _maTB);
                cmd.Parameters.AddWithValue("@TENTB", _thietBi.tenTb);
                cmd.Parameters.AddWithValue("@LOAITB", _thietBi.loaiTb);
                cmd.Parameters.AddWithValue("@SOLUONG", _thietBi.soLuong);
                cmd.Parameters.AddWithValue("@HANGSANXUAT", _thietBi.hsx);
                cmd.Parameters.AddWithValue("@TINHTRANG", _thietBi.tinhTrang);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thiết bị thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật!");
                }
                connection.Close();
            }
        }

        public void xoaThietBi(int _maTb)
        {
            string query = "DELETE FROM THIETBI WHERE MATB = @MATB";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MATB", _maTb);

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

        public DataTable timThietBi(string _search)
        {
            string query = "SELECT * FROM THIETBI WHERE TENTB LIKE N'%" + _search + "%'";
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
