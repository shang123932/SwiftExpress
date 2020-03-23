using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiSDKClient.FApi.Request;
using ApiSDKClient.FApi.Response.Area;
using BLL.Area;
using MODEL.Area;

namespace SwiftExpressApi.Controllers.Area
{
    /// <summary>
    /// 地区控制器
    /// </summary>
    /// 
    public class AreaController : ApiController
    {

        AreaBLL abll = new AreaBLL();
        #region  zrx  2020年3月21日22:12:36

        /// <summary>
        /// 获取省份
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        
        public List<AreaModel> GetProvince()
        {
            return abll.GetProvince();
        }
        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [HttpPost]
        public List<AreaModel> GetCity(AreaCityRequest request)
        {
            return abll.GetCity(request);
        }
        #endregion
    }
}
