
using ApiSDKClient;
using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.FApi.Response;
using ApiSDKClient.FApi.Response.ShippingInfor;
using ApiSDKClient.FApi.Response.Staff;
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
        WareHouseBll wbll = new WareHouseBll();
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
        public UserRegisteredResponse Registered(UserRegisteredRequest reg)
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
        ///查询接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public GetCxDistributionResponse GetCxDistribution(GetCxDistributionRequest getCx)
        {
            return disbll.GetCxDistribution(getCx);
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
        /// <summary>
        /// 获取一条配送数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GetOneDistributionResponse GetOneDistribution(GetOneDistributionRequest getOne)
        {
            return disbll.GetOneDistribution(getOne);
        }
        /// <summary>
        /// 修改配送信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public UpdateDistributionResponse SaveDistribution(UpdateDistributionRequest info)
        {
            return disbll.SaveDistribution(info);
        }


        /// <summary>
        /// 寄件信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ADDShippingInforResonse AddShipp(ADDShippingInforRequest info)
        {
            return userBll.AddShipp(info);
        }

        /// <summary>
        /// 员工显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GetStaffResponse Staffbllshow()
        {
            return disbll.Staffbllshow();
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="userlogin"></param>
        /// <returns></returns>
        [HttpPost]
        public AdminLoginResponse AdminLogin(AdminLoginRequest request)
        {
            return userBll.AdminLogin(request);
        }

        /// <summary>
        /// 显示仓库下拉
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public WareHouseBllResponse WareHouseBllShow()
        {
            return wbll.WareHouseBllShow();
        }

    }
}
