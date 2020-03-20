using ApiSDKClient;
using ApiSDKClient.FApi.Request.User;
using ApiSDKClient.FApi.Response;
using BLL;
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
        UserBll userBll = new UserBll();
        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public UserLoginResponse AddLogin(UserLoginRequest user)
        {
            return userBll.UserLogin(user);
        }
    }
}
