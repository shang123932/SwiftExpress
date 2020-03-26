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
                response.User = list;
                response.Message = $"获取信息成功";
            }
            return response;
        }

        /// <summary>
        /// 配送查询
        /// </summary>
        /// <returns></returns>
        public GetCxDistributionResponse GetCxDistribution(GetCxDistributionRequest request)
        {
            GetCxDistributionResponse response = new GetCxDistributionResponse();

            var list = disdal.GetCxDistribution(request.name);
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

        /// <summary>
        /// 获取一条配送数据
        /// </summary>
        /// <returns></returns>
        public GetOneDistributionResponse GetOneDistribution(GetOneDistributionRequest request)
        {
            var info = disdal.GetOneDistribution(request.pid);
            GetOneDistributionResponse response = new GetOneDistributionResponse()
            {
                DistributionId = info.DistributionId,
                ShippingOrder = info.ShippingOrder,
                StaffId = info.StaffId,
                     WareHouseId=info.WareHouseId,
                     PickTime = info.PickTime,
                     SendTime =info.SendTime,
                     SendType = info.SendType,
                     SendState = info.SendState,
                     SendRemark=info.SendRemark
            };
            //判断pid是否存在
            if (request.pid> 0)
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
        /// 修改配送
        /// </summary>
        /// <returns></returns>
        public UpdateDistributionResponse SaveDistribution(UpdateDistributionRequest request)
        {
            UpdateDistributionResponse response = new UpdateDistributionResponse();
            DistributionModel ware = new DistributionModel()
            {
                DistributionId = request.DistributionId,     
                StaffId = request.StaffId,
                 WareHouseId=request.WareHouseId,
              
            };
            //获取名不能为空
            if (request == null || !string.IsNullOrEmpty(request.StaffId.ToString()))
            {
                response.Status = false;
                response.Message = "员工id不能为空";
                return response;
            }
            if (!string.IsNullOrEmpty(request.WareHouseId.ToString()))
            {
                response.Status = false;
                response.Message = "仓库id不能为空";
                return response;
            }


            var res =disdal.SaveDistribution(ware);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "修改成功";
            }
            else
            {
                response.Status = false;
                response.Message = "修改失败";
                return response;
            }
            return response;

        }

    }
}
