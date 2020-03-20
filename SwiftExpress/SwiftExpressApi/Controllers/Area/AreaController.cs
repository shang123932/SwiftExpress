using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Area;
using MODEL.Area;

namespace SwiftExpressApi.Controllers.Area
{
    /// <summary>
    /// 地区控制器
    /// </summary>
    public class AreaController : ApiController
    {
        #region  zrx 
        
        /// <summary>
        /// 获取省份
        /// </summary>
        /// <returns></returns>
        public List<AreaModel> GetProvince()
        {
            return AreaBLL.getInstance().;
        }
        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<AreaModel> GetCity(int pid)
        {
            return areaBll.GetCity(pid);
        }
        #endregion
    }
}
