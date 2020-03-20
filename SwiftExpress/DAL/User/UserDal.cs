using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public int UserLogin(string UserPhone, string PassWord)
        {
            string sql = $"select count(1) from UserInfo where UserPhone='{UserPhone}' and PassWord='{PassWord}'";
            return Convert.ToInt32( DBHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserAdd(UserModel user)
        {
            string sql = $"insert into UserInfo(UserPhone,PassWord) values('{user.UserPhone}','{user.PassWord}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}
