﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;//引用数据库客户端
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
namespace DAL
{
    public class DBHelper
    {
        //连接数据库
        static SqlConnection Getconn()
        {
               return new SqlConnection("Data Source=.;Initial Catalog=SwiftExpress;Integrated Security=True");
        } 
        /// <summary>
        /// 返回受影响行数  
        /// 添加、删除、修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = Getconn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return n;
            }          
        }
        /// <summary>
        /// 数据流转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sdr"></param>
        /// <returns></returns>
        private static List<T> DataReaderToList<T>(SqlDataReader sdr) {
            Type t = typeof(T);//获取类型
            //获取所有属性
            PropertyInfo[] p = t.GetProperties();
            //定义集合
            List<T> list = new List<T>();
            //遍历数据流
            while (sdr.Read()) {
                //创建对象
                T obj = (T)Activator.CreateInstance(t);
                //数据流列数
                string[] sdrFileName = new string[sdr.FieldCount];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    sdrFileName[i] = sdr.GetName(i).Trim();
                }
                foreach (PropertyInfo item in p)
                {
                    //判断Model中的属性是否在流的列名中
                    if (sdrFileName.ToList().IndexOf(item.Name) > -1)
                    {
                        
                      if (sdr[item.Name] != null && sdr[item.Name] != DBNull.Value)
                        {
                            item.SetValue(obj, sdr[item.Name]);//对象属性赋值
                        }
                        else
                        {
                            item.SetValue(obj, null);//对象属性赋值
                        }
                    }
                    else {
                        item.SetValue(obj, null);//对象属性赋值
                    }
                   
                }
                list.Add(obj);
            }
            return list;
        }
        /// <summary>
        /// 获取list集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetToList<T>(string sql) {

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SwiftExpress;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                List<T> list = DataReaderToList<T>(sdr);
                sdr.Close();
                return list;
            }
        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = Getconn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object n = cmd.ExecuteScalar();
                conn.Close();
                return n;
            }
        }

    }
}
