using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 用户表
    /// </summary>
  public  class UserModel
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId        { get; set; }
        /// <summary>
        /// 用户手机号码
        /// </summary>
        public string UserPhone     { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord      { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string UserMailbox { get; set; }
    }
}
