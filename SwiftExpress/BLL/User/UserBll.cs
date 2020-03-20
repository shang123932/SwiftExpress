using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User
{
   public class UserBll
    {
        UserDal d = new UserDal();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public int UserLogin(string UserPhone, string PassWord)
        {

            return d.UserLogin(UserPhone,PassWord);
        }
    }
}
