using DAL.WareHouse;
using MODEL.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient.FApi.Response.WareHouse;
using ApiSDKClient.FApi.Request.WareHouse;

namespace BLL.WareHouse
{
    /// <summary>
    /// 仓库bll  zrx 2020年3月24日14:35:38
    /// </summary>
    public class WareHouseBLL
    {
        WareHouseDAL wdal = new WareHouseDAL();
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseAddResponse AddWareHouse(WareHouseAddRequest request)
        {
            WareHouseAddResponse response = new WareHouseAddResponse();
            if (request == null || !string.IsNullOrEmpty(request.WareHouseName))
            {
                response.Status = false;
                response.Message = "仓库名不能为空";
                return response;
            }
            if (request == null || !string.IsNullOrEmpty(request.WareHouseAddress))
            {
                response.Status = false;
                response.Message = "仓库地址不能为空";
                return response;
            }

            WareHouseInfo ware = new WareHouseInfo()
            {
                WareHouseName = request.WareHouseName,
                WareHouseCapacity = request.WareHouseCapacity,
                WareHouseAddress = request.WareHouseAddress,
                WareHouseStatus = request.WareHouseStatus,
                WareHouseRemark = request.WareHouseRemark
            };
            var res = wdal.AddWareHouse(ware);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加仓库成功";
            }
            else
            {
                response.Status = false;
                response.Message = "添加仓库失败";

            }

            return response;
        }
        /// <summary>
        /// 获取一条仓库数据
        /// </summary>
        /// <returns></returns>
        public WareHouseGetOneResponse GetOneWareHouse(WareHouseGetOneRequest request)
        {
            var info = wdal.GetOneWareHouse(request.pid);
            WareHouseGetOneResponse response = new WareHouseGetOneResponse()
            {
                WareHouseId = info.WareHouseId,
                 WareHouseName = info.WareHouseName,
                 WareHouseAddress = info.WareHouseAddress,
                 WareHouseCapacity = info.WareHouseCapacity,
                 WareHouseRemark = info.WareHouseRemark,
                 WareHouseStatus = info.WareHouseStatus
                 
            };
            //判断pid是否存在
            if (request.pid > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            else
            {
                response.Status = false;
                response.Message = "未获取选中数据";
                return response;
            }


            return response;
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseUpdateResponse SaveWareHouse(WareHouseUpdateRequest  request)
        {
            WareHouseUpdateResponse response = new WareHouseUpdateResponse();
            WareHouseInfo ware = new WareHouseInfo()
            {
                 WareHouseName = request.WareHouseName,
                 WareHouseAddress = request.WareHouseAddress,
                 WareHouseCapacity = request.WareHouseCapacity,
                 WareHouseRemark = request.WareHouseRemark,
                 WareHouseStatus = request.WareHouseStatus
            };
            //获取名不能为空
            if (request == null || !string.IsNullOrEmpty(request.WareHouseName))
            {
                response.Status = false;
                response.Message = "仓库名称不能为空";
                return response;
            }
            if (!string.IsNullOrEmpty(request.WareHouseAddress))
            {
                response.Status = false;
                response.Message = "仓库地址不能为空";
                return response;
            }
            
           
            var res = wdal.SaveWareHouse(ware);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "保存成功";
            }
            else
            {
                response.Status = false;
                response.Message = "保存失败";
                return response;
            }
            return response;
           
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseDelResponse DelWareHouse(WareHouseDelRequest request)
        {
            WareHouseDelResponse response = new WareHouseDelResponse();

            var res = wdal.DelWareHouse(request.id);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "删除成功";
            }
            else
            {
                response.Status = false;
                response.Message = "删除失败";
                return response;
            }
            return response;
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public WareHouseGetResponse GetWareHouses(WareHouseGetRequest request)
        {
            WareHouseGetResponse response = new WareHouseGetResponse();
            var list = wdal.GetWareHouses(request.name);
            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取失败";
            }
            else
            {
                response.wareahouselist = list;
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            return response;
        }

    }
}
