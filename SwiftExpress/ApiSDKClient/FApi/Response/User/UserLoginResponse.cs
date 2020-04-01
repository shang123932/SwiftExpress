using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class UserLoginResponse:BaseResponse
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
    }
}
