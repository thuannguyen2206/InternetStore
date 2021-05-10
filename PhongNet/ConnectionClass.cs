using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongNet
{
    public class ConnectionClass
    {
        private static ConnectionClass instance;//duy nhất 1 đối tượng được gọi

        public static ConnectionClass Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectionClass();
                return ConnectionClass.instance;
            }

            private set
            {
                ConnectionClass instance = value;
            }
        }
        private ConnectionClass()
        {

        }

        private string con = @"Data Source=DESKTOP-UHUFF6E\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";

        //trả về bảng dữ liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection connection=new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)//câu try vấn có parameter
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)//thêm parameter 
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
        //trả về số dòng thành công (thêm, xóa,...)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conection = new SqlConnection(con))
            {
                conection.Open();
                SqlCommand command = new SqlCommand(query, conection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                conection.Close();
            }
            return data;
        }
        //trả về ô đầu tiên của bảng kết quả (đếm, ...)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conection = new SqlConnection(con))
            {
                conection.Open();
                SqlCommand command = new SqlCommand(query, conection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                conection.Close();
            }
            return data;
        }
    }
}
