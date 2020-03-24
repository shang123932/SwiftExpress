
using ApiSDKClient;
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
        DistributionBll disbll = new DistributionBll();
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

        /// <summary>
        /// 注册接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public UserRegisteredResponse Registered(UserRegisteredRequest  reg)
        {
            return userBll.UserRegistered(reg);
        }
        /// <summary>
        ///显示接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public DistributionResponseGet GetDistribution()
        {
            return disbll.GetDistribution();
        }

        /// <summary>
        /// 添加接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public AddDistributionResponse AddDistribution(AddDistributionRequest reg)
        {
            return disbll.AddDistribution(reg);
        }
        
        /// <summary>
        /// 删除接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest reg)
        {
            return disbll.DeleteDistribution(reg);
        }

    }
}
