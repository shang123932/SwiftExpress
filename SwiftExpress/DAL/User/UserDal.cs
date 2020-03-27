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
        /// 用户登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public int UserLogin(UserModel u)
        {
            string sql = $"select count(1) from UserInfo where UserPhone='{u.UserPhone}' and PassWord='{u.PassWord}' and UserStatus=1";

            return Convert.ToInt32( DBHelper.ExecuteScalar(sql));
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public int Administrator(UserModel u)
        {
            string sql = $"select count(1) from UserInfo where UserPhone='{u.UserPhone}' and PassWord='{u.PassWord}' and UserStatus=1";

            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserRegistered(UserModel user)
        {
            string sql = $"insert into UserInfo(UserPhone,PassWord,UserMailbox,UserStatus,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values('{user.UserPhone}','{user.PassWord}','{user.UserMailbox}',1,1,GETDATE(),GETDATE(),1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}
