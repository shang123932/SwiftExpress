using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
  public  class AdminLoginResponse:BaseResponse
    {
        /// <summary>
        /// 管理员
        /// </summary>
        public string Aname { get; set; }
    }
}
