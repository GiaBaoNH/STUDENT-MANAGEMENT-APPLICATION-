using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyHocVien_Nhom8
{
    public class DBConnect
    {
        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        //chuỗi kết nối csdl SQL
        string strConnect = @"Data Source=DESKTOP-SS9RUEB\MSSQLSERVERRR;Initial Catalog=QL_HocVien;Integrated Security=True";
        public DBConnect()
        {
            connect = new SqlConnection(strConnect);
        }

        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public void close()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        // Thực thi câu lệnh SQL không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public int getNonQuery(string sql, Dictionary<string, object> parameters = null)
        {
            open();
            // Tạo đối tượng SqlCommand với câu lệnh SQL và kết nối
            SqlCommand cmd = new SqlCommand(sql, connect);

            // Nếu có tham số, thêm vào câu lệnh
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }
        // Thực thi câu lệnh SQL và trả về SqlDataReader để đọc dữ liệu
        public SqlDataReader getDataReader(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            //close();
            return rd;
        }
        // Thực thi câu lệnh SQL và trả về giá trị duy nhất (thường là kết quả của các hàm tổng hợp)
        public object getScalar(string sql, Dictionary<string, object> parameters = null)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);

            // Thêm tham số nếu có
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }

        // Thực thi câu lệnh SQL và trả về DataTable với dữ liệu
        public DataTable getDatatable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        // Cập nhật cơ sở dữ liệu dựa trên DataTable và câu lệnh SQL
        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da_lop = new SqlDataAdapter(sql, Connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da_lop);
            int kq = da_lop.Update(dt);
            return kq;
        }
    }
}
