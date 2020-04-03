using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class AdminLoginRequest:BaseRequest
    {
        /// <summary>
        /// 管理员名
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string AdminPhone { get; set; }
        public string AdminPwd { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AdminLogin";
        }

    }
}
