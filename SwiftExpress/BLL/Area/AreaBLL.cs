﻿using MODEL.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Area;
using ApiSDKClient.FApi.Request;
using ApiSDKClient.FApi.Response.Area;
using ApiSDKClient.FApi.Request.Area;

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
        public AreaProvinceResponse GetProvince()
        {
            AreaProvinceResponse response = new AreaProvinceResponse();
            var list = areaDal.GetProvince();
            if (list.Count < 0)
            {
                response.Status = false;
                response.Message = "获取失败";
            }
            else
            {
                response.arealist = list;
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            return response;
        }

        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="cityRequest"></param>
        /// <returns></returns
        public AreaCityResponse GetCity(AreaCityRequest request)
        {
            AreaCityResponse response = new AreaCityResponse();
            var alist = areaDal.GetCity(request.pid);
            if (alist.Count < 0)
            {
                response.Status = false;
                response.Message = "获取失败";
            }
            else
            {
                response.Alist = alist;
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            return response;
        }

        /// <summary>
        /// 获取运费
        /// </summary>
        /// <param name="did"></param>
        /// <returns></returns>
        public AreaFreResponse GetFre(AreaFreRequest request)
        {
            AreaFreResponse response = new AreaFreResponse();
            var res = areaDal.GetFre(request.did);
            if (res>0)
            {
                response.fid = res;
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            else
            {
                response.Status = false;
                response.Message = "获取失败";
               
            }

            return response;
        }
        #endregion
    }
}
