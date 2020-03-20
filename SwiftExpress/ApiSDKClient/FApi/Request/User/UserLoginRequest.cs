using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.User
{
    public class UserLoginRequest:BaseRequest
    {
        
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AddLogin";
        }
    }
}
