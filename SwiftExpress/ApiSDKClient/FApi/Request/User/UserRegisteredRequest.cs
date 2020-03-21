using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class UserRegisteredRequest:BaseRequest
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string UserMailbox { get; set; }

        public override string GetApiName()
        {
            return "/api/User/Registered";
        }
    }
}
