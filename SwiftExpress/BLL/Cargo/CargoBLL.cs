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
                CargoState = request.CargoState,
                CargoRemark = request.CargoRemark
            };
            //获取名不能为空
            if (request == null || !string.IsNullOrEmpty(request.CargoName))
            {
                response.Status = false;
                response.Message = "货物名称不能为空";
                return response;
            }
            //重量不能为0
            if (request.CargoWeight == 0)
            {
                response.Status = false;
                response.Message = "重量不能为空";
                return response;
            }
            //验证货物是否存在
            var shiporder = cdal.IsExistShipping(request.ShippingOrder);
            if (shiporder < 1)
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
        public CargoGetOneResponse GetOneCargo(CargoGetOneRequest request)
        {
            var info = cdal.GetOneCargo(request.pid);
            CargoGetOneResponse response = new CargoGetOneResponse()
            {
                CargoId = info.CargoId,
                CargoName = info.CargoName,
                CargoRemark = info.CargoRemark,
                CargoState = info.CargoState,
                CargoType = info.CargoType,
                CargoWeight = info.CargoWeight,
                ShippingOrder = info.ShippingOrder
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
        public CargoUpdateResponse SaveCargo(CargoUpdateRequest request)
        {
            CargoUpdateResponse response = new CargoUpdateResponse();
            CargoInfo cargo = new CargoInfo()
            {
                CargoName = request.CargoName,
                ShippingOrder = request.ShippingOrder,
                CargoWeight = request.CargoWeight,
                CargoType = request.CargoType,
                CargoState = request.CargoState,
                CargoRemark = request.CargoRemark
            };
            if (request == null ||string.IsNullOrEmpty(request.CargoName))
            {
                response.Status = false;
                response.Message = "货物名称不能为空";
                return response;
            }
            //获取名不能为空
            if (request.CargoWeight == 0)
            {
                response.Status = false;
                response.Message = "重量不能为空";
                return response;
            }
            //验证货物是否存在
            var shiporder = cdal.IsExistShipping(request.ShippingOrder);
            if (shiporder < 1)
            {
                response.Status = false;
                response.Message = "货物已存在";
                return response;
            }
            var res = cdal.SaveCargo(cargo);
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
        public CargoDelResponse DelCargo(CargoDelRequest request)
        {
            CargoDelResponse response = new CargoDelResponse();

            var res = cdal.DelCargo(request.id);
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
        public CargoGetResponse GetCargo()
        {
            CargoGetResponse response = new CargoGetResponse();
            var list = cdal.GetCargo();
            if (list.Count < 0)
            {
                response.Status = false;
                response.Message = "获取失败";
            }
            else
            {
                response.cargolist = list;
                response.IsRegistSuccess = true;
                response.Message = "获取成功";
            }
            return response;
        }

    }
}
