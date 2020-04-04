using MODEL;
using MODEL.Staff;
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
            string sql = $"select count(1) from UserInfo where UserName='{u.UserName}' and PassWord='{u.PassWord}' and UserStatus=1";

            return Convert.ToInt32( DBHelper.ExecuteScalar(sql));
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public string Administrator(StaffModel s)
        {
            string sql = $"select staffname from Staff where StaffName='{s.StaffName}' or StaffPhone='{s.StaffPhone}' and StaffPwd='{s.StaffPwd}' and StaffStatus=1 and StaffDuty=3";

            return DBHelper.ExecuteScalar(sql).ToString();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserRegistered(UserModel user)
        {
            string sql = $"insert into UserInfo(UserName,UserPhone,PassWord,PassJmi,UserMailbox,UserStatus,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values('{user.UserName}','{user.UserPhone}','{user.PassWord}','{user.PassJmi}','{user.UserMailbox}',1,1,GETDATE(),GETDATE(),1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}
