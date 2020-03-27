using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient.FApi.Request;
using ApiSDKClient.FApi.Request.Area;
using ApiSDKClient.FApi.Response.Area;

namespace BLL
{
    /// <summary>
    /// 地区的BLL
    /// </summary>
   public class AreaBll
    {
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="getRequest"></param>
        /// <returns></returns>
        public AreaProvinceResponse GetProvince(AreaProvinceRequest getRequest)
        {
            return ApiRequestHelper.Post<AreaProvinceRequest, AreaProvinceResponse>(getRequest);
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="getRequest"></param>
        /// <returns></returns>
        public AreaCityResponse GetCity(AreaCityRequest getRequest)
        {
            return ApiRequestHelper.Post<AreaCityRequest, AreaCityResponse>(getRequest);
        }
    }
}
