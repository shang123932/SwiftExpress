using MODEL.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Area;
using ApiSDKClient.FApi.Request;
using ApiSDKClient.FApi.Response.Area;

namespace BLL.Area
{
    /// <summary>
    /// 地区BLL
    /// </summary>
   public  class AreaBLL
    {
        #region  zrx 2020年3月21日22:28:30
        AreaDal areaDal = new AreaDal();
        /// <summary>
        /// 获取省份
        /// </summary>
        /// <returns></returns>
        public List<AreaModel> GetProvince()
        {
            return areaDal.GetProvince();
        }
        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="cityRequest"></param>
        /// <returns></returns>
        public List<AreaModel> GetCity(AreaCityRequest cityRequest)
        {
            var pid = cityRequest.pid;
            var list = areaDal.GetCity(pid);
            return list;
        }
        #endregion
    }
}
