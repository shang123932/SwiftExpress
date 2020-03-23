using ApiSDKClient.FApi.Request.Cargo;
using ApiSDKClient.FApi.Response.Cargo;
using DAL.Cargo;
using MODEL.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cargo
{
   public class CargoBLL
    {
        CargoDAL cdal = new CargoDAL();
        /// <summary>
        /// 添加仓库   zrx   2020年3月23日15:20:31
        /// </summary>
        /// <returns></returns>
        public CargoAddResponse AddCargo(CargoAddRequest request)
        {
            CargoAddResponse response = new CargoAddResponse();
           

            CargoInfo cargo = new CargoInfo()
            {
                 CargoName = request.CargoName,
                 ShippingOrder = request.ShippingOrder,
                 CargoWeight = request.CargoWeight,
                 CargoType = request.CargoType,
                 CargoState  = request.CargoState,
                  CargoRemark= request.CargoRemark
            };
            if (request==null||!string.IsNullOrEmpty(request.CargoName))
            {
                response.Status = false;
                response.Message = "货物名称不能为空";
                return response;
            }
            //验证货物是否存在
            var shiporder = cdal.IsExistShipping(request.ShippingOrder);
            if (shiporder<1)
            {
                response.Status = false;
                response.Message = "货物已存在";
                return response;
            }
            
            var res = cdal.AddCargo(cargo);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加货物成功";
            }
            else
            {
                response.Status = false;
                response.Message = "添加货物失败";

            }

            return response;
        }
        /// <summary>
        /// 获取一条仓库数据
        /// </summary>
        /// <returns></returns>
        public CargoInfo GetOneCargo(int pid)
        {
            return cdal.GetOneCargo(pid);
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        public int SaveCargo(CargoInfo info)
        {
            return cdal.SaveCargo(info);
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        public int DelCargo(int id)
        {
            return cdal.DelCargo(id);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public List<CargoInfo> GetCargo()
        {
            return cdal.GetCargo();
        }
    }
}
