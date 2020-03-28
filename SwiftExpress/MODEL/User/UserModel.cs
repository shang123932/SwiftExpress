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
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户手机号码
        /// </summary>
        public string UserPhone     { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord      { get; set; }
        /// <summary>
        /// 加密
        /// </summary>
        public string PassJmi { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string UserMailbox { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int UserStatus { get; set; }
        /// <summary>
        /// 状态 1正常-1删除
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreateId { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public int UpdateId { get; set; }
    }
}
