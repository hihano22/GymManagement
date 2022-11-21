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
    internal class HoiVienDAO
    {
        private const string connectionStr = @"Data Source=DESKTOP-DCI7V8V\SQLEXPRESS;Initial Catalog = gym1; Integrated Security = True";

        private static HoiVienDAO? instance;

        public static HoiVienDAO Instance
        { get { return instance ?? (instance = new HoiVienDAO()); } }

        private HoiVienDAO() { }

        public DataTable loadDataHV()
        {
            string query = "SELECT MAHOCVIEN AS [Mã học viên], " +
                "TENHOCVIEN AS [Tên học viên], " +
                "DIACHI AS [Địa chỉ], " +
                "SDT AS [SĐT], " +
                "SONGAYTAP AS [Số ngày tập], " +
                "NGAYDANGKY AS [Ngày đăng ký], " +
                "NGAYHETHAN AS [Ngày hết hạn], " +
                "GOITAP AS [Gói tập], " +
                "GIOITINH AS [Giới tính] " +
                "FROM HOIVIEN";
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

        public void themHV(HoiVien _hoiVien)
        {
            string query = "INSERT INTO HOIVIEN " +
                " (TENHOCVIEN, DIACHI, SDT, SONGAYTAP, NGAYDANGKY, NGAYHETHAN, GOITAP, GIOITINH)" +
                " VALUES(@TENHOCVIEN, @DIACHI, @SDT, @SONGAYTAP, @NGAYDANGKY, @NGAYHETHAN, @GOITAP, @GIOITINH)";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //cmd.Parameters.AddWithValue("@MAHOCVIEN", _maHoiVien);
                cmd.Parameters.AddWithValue("@TENHOCVIEN", _hoiVien.tenHocVien);
                cmd.Parameters.AddWithValue("@GIOITINH", _hoiVien.gioiTinh);
                cmd.Parameters.AddWithValue("@GOITAP", _hoiVien.goiTap);
                cmd.Parameters.AddWithValue("@SDT", _hoiVien.sdt);
                cmd.Parameters.AddWithValue("@SONGAYTAP", _hoiVien.soNgayTap);
                cmd.Parameters.AddWithValue("@NGAYDANGKY", _hoiVien.ngayDangKy);
                cmd.Parameters.AddWithValue("@NGAYHETHAN", _hoiVien.ngayHetHan);
                cmd.Parameters.AddWithValue("@DIACHI", _hoiVien.diaChi);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi thêm!");
                }
                connection.Close();
            }
        }

        public void suaHV(int _maHoiVien, HoiVien _hoiVien)
        {
            string query = "UPDATE HOIVIEN SET TENHOCVIEN = @TENHOCVIEN, " +
                " GIOITINH = @GIOITINH," +
                " GOITAP = @GOITAP," +
                " SDT = @SDT WHERE MAHOCVIEN = @MAHOCVIEN";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MAHOCVIEN", _maHoiVien);
                cmd.Parameters.AddWithValue("@TENHOCVIEN", _hoiVien.tenHocVien);
                cmd.Parameters.AddWithValue("@GIOITINH", _hoiVien.gioiTinh);
                cmd.Parameters.AddWithValue("@GOITAP", _hoiVien.goiTap);
                cmd.Parameters.AddWithValue("@SDT", _hoiVien.sdt);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật!");
                }
                connection.Close();
            }
        }

        public void xoaHV(int _maHoiVien)
        {
            string query = "DELETE FROM HOIVIEN WHERE MAHOCVIEN = @MAHOCVIEN";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MAHOCVIEN", _maHoiVien);

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

        public DataTable timHV(string _tenHoiVien)
        {
            string query = "SELECT * FROM HOIVIEN WHERE TENHOCVIEN LIKE N'%" + _tenHoiVien + "%'";
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
