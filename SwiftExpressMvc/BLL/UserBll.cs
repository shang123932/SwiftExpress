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


        /// <summary>
        /// 配送信息显示
        /// </summary>
        /// <param name="userRegistered"></param>
        /// <returns></returns>
        public DistributionResponseGet GetDistribution(DistributionRequestGet loginRequest)
        {
            return ApiRequestHelper.Post<DistributionRequestGet, DistributionResponseGet>(loginRequest);
        }

        /// <summary>
        /// 配送查询
        /// </summary>
        /// <returns></returns>
        public GetCxDistributionResponse GetCxDistribution(GetCxDistributionRequest request)
        {
            return ApiRequestHelper.Post<GetCxDistributionRequest, GetCxDistributionResponse>(request);
        }

        /// <summary>
        /// 配送 添加 
        /// </summary>
        /// <returns></returns>
        public AddDistributionResponse AddDistribution(AddDistributionRequest addDistribution)
        {
            return ApiRequestHelper.Post<AddDistributionRequest, AddDistributionResponse>(addDistribution);
        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest ids)
        {
            return ApiRequestHelper.Post<DeleteDistributionRequest, DeleteDistributionResponse>(ids);
        }

        /// <summary>
        /// 获取一条配送数据
        /// </summary>
        /// <returns></returns>
        public GetOneDistributionResponse GetOneDistribution(GetOneDistributionRequest request)
        {
            return ApiRequestHelper.Post<GetOneDistributionRequest, GetOneDistributionResponse>(request);
        }
        /// <summary>
        /// 修改配送
        /// </summary>
        /// <returns></returns>
        public UpdateDistributionResponse SaveDistribution(UpdateDistributionRequest request)
        {
            return ApiRequestHelper.Post<UpdateDistributionRequest, UpdateDistributionResponse>(request);

        }



    }
}
