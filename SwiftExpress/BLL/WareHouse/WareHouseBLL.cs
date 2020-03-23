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
        public WareHouseInfo GetOneWareHouse(int pid)
        {
            return wdal.GetOneWareHouse(pid);
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        public int SaveWareHouse(WareHouseInfo info)
        {
            return wdal.SaveWareHouse(info);
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        public int DelWareHouse(int id)
        {
            return wdal.DelWareHouse(id);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public List<WareHouseInfo> GetWareHouses()
        {
            return wdal.GetWareHouses();
        }
    }
}
