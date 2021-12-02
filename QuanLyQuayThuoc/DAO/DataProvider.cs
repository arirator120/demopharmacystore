﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        private static volatile DataProvider instance;
        private DataProvider() { }
        public static DataProvider Instance 
        {
            get {
                if (instance == null) 
                {
                   instance = new DataProvider();
                }
                return DataProvider.instance;
            }
        }
        private string connectionString = "Data Source=DESKTOP-9PK089S;Initial Catalog=QuanLyQuayThuoc;Integrated Security=True";

        /// <summary>
        /// Lấy dữ liệu từ Database và trả về giá trị ở dạng bảng
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        // @ chứa parameter để thực thi procedure
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

        /// <summary>
        /// Lấy dữ liệu từ Database và trả về số dòng của bảng đang xét
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        // @ chứa parameter để thực thi procedure 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}
