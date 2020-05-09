using ApiSDKClient;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class WareHouseBll
    {
        WareHouseId2 id2 = new WareHouseId2();
        /// <summary>
        /// 显示仓库下拉
        /// </summary>
        /// <returns></returns>
        public WareHouseBllResponse WareHouseBllShow()
        {
            WareHouseBllResponse response = new WareHouseBllResponse();

            var list = id2.WareHouseIdss();

            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取用户信息失败,请检查一下在弄";
            }
            else
            {
                response.Id = list;
                response.Message = $"获取信息成功";
            }
            return response;
        }
    }
}
