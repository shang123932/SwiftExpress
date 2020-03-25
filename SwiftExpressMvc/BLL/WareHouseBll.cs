using ApiSDKClient.FApi.Request.WareHouse;
using ApiSDKClient.FApi.Response.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 仓库的BLL
    /// </summary>
   public class WareHouseBll
    {

        /// <summary>
        /// 仓库添加
        /// </summary>
        /// <param name="addRequest"></param>
        /// <returns></returns>
        public WareHouseAddResponse WareHouseAdd(WareHouseAddRequest addRequest)
        {
            return ApiRequestHelper.Post<WareHouseAddRequest, WareHouseAddResponse>(addRequest);
        }
        /// <summary>
        /// 仓库删除
        /// </summary>
        /// <param name="delRequest"></param>
        /// <returns></returns>
        public WareHouseDelResponse WareHouseDel(WareHouseDelRequest delRequest)
        {
            return ApiRequestHelper.Post<WareHouseDelRequest, WareHouseDelResponse>(delRequest);
        }

        /// <summary>
        /// 获取一条信息
        /// </summary>
        /// <param name="getoneRequest"></param>
        /// <returns></returns>
        public WareHouseGetOneResponse WareHouseGetOne(WareHouseGetOneRequest getoneRequest)
        {
            return ApiRequestHelper.Post<WareHouseGetOneRequest, WareHouseGetOneResponse>(getoneRequest);
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="getRequest"></param>
        /// <returns></returns>
        public WareHouseGetResponse WareHouseGet(WareHouseGetRequest getRequest)
        {
            return ApiRequestHelper.Post<WareHouseGetRequest, WareHouseGetResponse>(getRequest);
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <param name="addRequest"></param>
        /// <returns></returns>
        public WareHouseUpdateResponse WareHouseSave(WareHouseAddRequest addRequest)
        {
            return ApiRequestHelper.Post<WareHouseAddRequest, WareHouseUpdateResponse>(addRequest);
        }
    }
}
