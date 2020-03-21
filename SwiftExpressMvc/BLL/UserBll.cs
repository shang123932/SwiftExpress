using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient;

namespace BLL
{
    public class UserBll
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userRegistered"></param>
        /// <returns></returns>
        public UserRegisteredResponse UserRegist(UserRegisteredRequest userRegistered)
        {
            return ApiRequestHelper.Post<UserRegisteredRequest, UserRegisteredResponse>(userRegistered);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userRegistered"></param>
        /// <returns></returns>
        public UserLoginResponse UserLogin(UserLoginRequest  loginRequest)
        {
            return ApiRequestHelper.Post<UserLoginRequest, UserLoginResponse>(loginRequest);
        }
    }
}
