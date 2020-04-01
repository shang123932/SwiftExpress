
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient;
namespace BLL
{
   public class ContrabandBll
    {
        ContrabandDal dal = new ContrabandDal();
        #region 违禁品
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public ContrabandResponse GetContrabands(ContrabandRequest request)
        {
            ContrabandResponse response = new ContrabandResponse();
            var list = dal.GetContrabands(request.ItemName);
            if (!string.IsNullOrEmpty(request.ItemName))
            {
                list = list.Where(w => w.ItemName.Contains(request.ItemName)).ToList();
            }
            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取失败";
            }
            else
            {
                response.Contrabandlist = list;
                response.IsRegistSuccess = true;
                response.Message = "成功";
            }
            return response;

        }
        #endregion


        #region 运单
        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AddWaybillLnquiryResponse AddWaybillLnquiry(AddWaybillLnquiryRequest request)
        {
            AddWaybillLnquiryResponse response = new AddWaybillLnquiryResponse();
            if (request == null || !string.IsNullOrEmpty(request.FreightTotal.ToString()))
            {
                response.Status = false;
                response.Message = "运费不能为空呀";
                return response;
            }
            if (request == null)
            {
                response.Status = false;
                response.Message = "快递时间不能为空呀";
                return response;
            }
            if (request == null || !string.IsNullOrEmpty(request.TrackingDetails))
            {
                response.Status = false;
                response.Message = "快递详情不能为空呀";
                return response;
            }
            if (request == null)
            {
                response.Status = false;
                response.Message = "物品状态不能为空呀";
                return response;
            }

            WaybillLnquiry waybill = new WaybillLnquiry()
            {
                FreightTotal = request.FreightTotal,
                TrackingDate = request.TrackingDate,
                TrackingDetails = request.TrackingDetails,
                TrackingState = request.TrackingState
            };
            var res = dal.AddWaybillLnquiry(waybill);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加成功";
            }
            else
            {
                response.Message = "添加失败";
            }
            return response;
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public GetWaybillLnquiryResponse GetWaybillLnquiry(GetWaybillLnquiryRequest bh)
        {
            GetWaybillLnquiryResponse response = new GetWaybillLnquiryResponse();
            var number = bh.TrackingNumber;
            var list = dal.GetWaybillLnquiry(number);

            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            else
            {
                response.Message = "成功";
            }
            return response;
        }
        /// <summary>
        /// 运单删除
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public DeleteWaybillLnquiryResponse DeleteWaybillLnquiry(DeleteWaybillLnquiryRequest request)
        {
            DeleteWaybillLnquiryResponse response = new DeleteWaybillLnquiryResponse();
            var res = dal.DeleteWaybillLnquiry(request.id);
            if (res>0)
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
        /// 修改运单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateWaybillLnquiryResponse UpdateWaybillLnquiry(UpdateWaybillLnquiryRequest request)
        {
            UpdateWaybillLnquiryResponse response = new UpdateWaybillLnquiryResponse();
            WaybillLnquiry waybill = new WaybillLnquiry()
            {
                FreightTotal = request.FreightTotal,
                TrackingDate = request.TrackingDate,
                TrackingDetails = request.TrackingDetails,
                TrackingState = request.TrackingState,
                Status=request.Status
            };
            var res = dal.UpdateWaybillLnquiry(waybill);
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
        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetOneWaybillLnquiryResponse GetOneWaybillLnquiry(GetOneWaybillLnquiryRequest request)
        {
            GetOneWaybillLnquiryResponse response = new GetOneWaybillLnquiryResponse();
            var res = dal.GetOneWaybillLnquiry(request.id);
            
            return response;
        }
        #endregion


        #region 存储
        /// <summary>
        /// 查询存储信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public GetStorageResponse GetStorage(/*GetStorageRequest request*/)
        {
            GetStorageResponse response = new GetStorageResponse();

            var list = dal.GetStorage();
            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取用户信息失败,请检查一下在弄";
            }
            else
            {
                response.Storagelist = list;
                response.IsRegistSuccess = true;
                response.Message = "获取信息成功";
            }
            return response;
        }

        public UpdateStorageResponse UpdateStorage(UpdateStorageRequest request)
        {
            UpdateStorageResponse response = new UpdateStorageResponse();
            Storage storage = new Storage()
            {
                StorageId=request.StorageId,
                CargoId=request.CargoId,
                WareHouseId=request.WareHouseId,
                StaffId=request.StaffId,
                InStorageTime = request.InStorageTime,
                InStorageNumber = request.InStorageNumber,
                OutStorageTime = request.OutStorageTime,
                OutStorageNumber = request.OutStorageNumber,
                Remark = request.Remark
            };

            var res = dal.UpdateStorage(storage);
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
        /// <summary>
        /// 删除存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DeleteStorageResponse DeleteStorage(DeleteStorageRequest request)
        {
            DeleteStorageResponse response = new DeleteStorageResponse();
            var res = dal.DeleteStorage(request.id);
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
        /// 获取一条存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetOneStorageResponse GetOneStorage(GetOneStorageRequest request)
        {
            GetOneStorageResponse response = new GetOneStorageResponse();
            var res = dal.GetOneStorage(request.id); //storages
            if (res==null)
            {
                response.Message = "请求失败";
            }
            else
            {
                response.storages = res;
            }
            return response;

        }

        /// <summary>
        /// 添加存储信息
        /// </summary>
        /// <returns></returns>
        public AddStorageResponse AddStorage(AddStorageRequest request)
        {
            AddStorageResponse response = new AddStorageResponse();
            Storage storage = new Storage()
            {
                CargoId = request.CargoId,
                WareHouseId = request.WareHouseId,
                StaffId = request.StaffId,
                InStorageTime = request.InStorageTime,
                InStorageNumber = request.InStorageNumber,
                OutStorageTime = request.OutStorageTime,
                OutStorageNumber = request.OutStorageNumber,
                Remark = request.Remark
            };
            var res = dal.AddStorage(storage);

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
        #endregion







    }
}
