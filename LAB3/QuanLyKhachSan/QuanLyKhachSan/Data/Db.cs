using System;
using System.Data;
using Microsoft.Data.SqlClient; // Đã đổi sang Microsoft.Data.SqlClient theo đúng gói bạn đã cài!

namespace QuanLyKhachSan.Data
{
    public class Db
    {
        private static readonly string connectionString = @"Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";

        // 1. Hàm Query (Trả về DataTable)
        public static DataTable Query(string sql, SqlParameter[]? parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch { }
            return dt;
        }

        // Tương thích với các Form cũ dùng Database.GetData()
        public static DataTable GetData(string sql, SqlParameter[]? parameters = null)
        {
            return Query(sql, parameters);
        }

        // 2. Hàm Execute (Thêm / Sửa / Xóa)
        public static bool Execute(string sql, SqlParameter[]? parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        // Tương thích với ExecuteNonQuery
        public static bool ExecuteNonQuery(string sql, SqlParameter[]? parameters = null)
        {
            return Execute(sql, parameters);
        }

        // 3. Hàm Scalar (Lấy 1 giá trị đơn)
        public static object? Scalar(string sql, SqlParameter[]? parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch { return null; }
        }
    }
}