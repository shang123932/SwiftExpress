using ApiSDKClient.FApi.Request.Cargo;
using ApiSDKClient.FApi.Response.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 货物bll
    /// </summary>
  public  class CargoBll
    {
        /// <summary>
        /// 货物添加
        /// </summary>
        /// <param name="addRequest"></param>
        /// <returns></returns>
        public CargoAddResponse CargoAdd(CargoAddRequest addRequest)
        {
            return ApiRequestHelper.Post<CargoAddRequest, CargoAddResponse>(addRequest);
        }
        /// <summary>
        /// 货物删除
        /// </summary>
        /// <param name="delRequest"></param>
        /// <returns></returns>
        public CargoDelResponse CargoDel(CargoDelRequest delRequest)
        {
            return ApiRequestHelper.Post<CargoDelRequest, CargoDelResponse>(delRequest);
        }

        /// <summary>
        /// 获取一条信息
        /// </summary>
        /// <param name="getoneRequest"></param>
        /// <returns></returns>
        public CargoGetOneResponse CargoGetOne(CargoGetOneRequest getoneRequest)
        {
            return ApiRequestHelper.Post<CargoGetOneRequest, CargoGetOneResponse>(getoneRequest);
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="getRequest"></param>
        /// <returns></returns>
        public CargoGetResponse CargoGet(CargoGetRequest getRequest)
        {
            return ApiRequestHelper.Post<CargoGetRequest, CargoGetResponse>(getRequest);
        }
        /// <summary>
        /// 保存货物
        /// </summary>
        /// <param name="addRequest"></param>
        /// <returns></returns>
        public CargoUpdateResponse CargoSave(CargoUpdateRequest addRequest)
        {
            return ApiRequestHelper.Post<CargoUpdateRequest, CargoUpdateResponse>(addRequest);
        }
    }
}
