using ApiSDKClient;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class DistributionBll
    {

        DistributionDal disdal = new DistributionDal();

        /// <summary>
        /// 配送显示
        /// </summary>
        /// <returns></returns>
        public DistributionResponseGet GetDistribution()
        {
            DistributionResponseGet response = new DistributionResponseGet();

            var list = disdal.GetDistribution();
            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取用户信息失败,请检查一下在弄";
            }
            else
            {
                response.Message = $"获取信息成功";
            }
            return response;
        }

        /// <summary>
        /// 配送 添加 
        /// </summary>
        /// <returns></returns>
        public AddDistributionResponse AddDistribution(AddDistributionRequest addDistribution)
        {
            AddDistributionResponse response = new AddDistributionResponse();


            DistributionModel dis = new DistributionModel()
            {
                ShippingOrder=addDistribution.ShippingOrder,
                StaffId=addDistribution.StaffId,
                WareHouseId=addDistribution.WareHouseId,
                PickTime=addDistribution.PickTime,
                SendTime=addDistribution.SendTime,
                SendType=addDistribution.SendType,
                SendState=addDistribution.SendState,
                SendRemark=addDistribution.SendRemark,
            };
            var res = disdal.AddDistribution(dis);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加配送信息成功";
            }
            else
            {
                response.Status = false;
                response.Message = "添加配送信息失败";

            }

            return response;

        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest ids)
        {
            DeleteDistributionResponse response = new DeleteDistributionResponse();
            var id = ids.Id;
            var res = disdal.DeleteDistribution(id);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "删除配送信息成功";
            }
            else
            {
                response.Status = false;
                response.Message = "删除配送信息失败";

            }
            return response;
        }
    }
}
