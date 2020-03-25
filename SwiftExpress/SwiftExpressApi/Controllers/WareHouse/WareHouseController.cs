using ApiSDKClient.FApi.Request.WareHouse;
using ApiSDKClient.FApi.Response.WareHouse;
using BLL.WareHouse;
using MODEL.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers.WareHouse
{
    public class WareHouseController : ApiController
    {
        WareHouseBLL wbll = new WareHouseBLL();
        /// <summary>
        /// 添加仓库   zrx   2020年3月24日15:00:01
        /// </summary>
        /// <returns></returns>
        public WareHouseAddResponse AddWareHouse(WareHouseAddRequest request)
        {

            return wbll.AddWareHouse(request);
        }
        /// <summary>
        /// 获取一条仓库数据
        /// </summary>
        /// <returns></returns>
        public WareHouseGetOneResponse GetOneWareHouse(WareHouseGetOneRequest request)
        {
            return wbll.GetOneWareHouse(request);
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseUpdateResponse SaveWareHouse(WareHouseAddRequest request)
        {
            return wbll.SaveWareHouse(request);
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseDelResponse DelWareHouse(WareHouseDelRequest request)
        {
            return wbll.DelWareHouse(request);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseGetResponse GetWareHouses(WareHouseGetRequest request)
        {
            return wbll.GetWareHouses(request);
        }
    }
}
