using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers.User
{
    public class UserController : ApiController
    {
        /// <summary>
        /// 注册添加用户接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddLogin()
        {
            return 0;
        }
    }
}
