using ApiSDKClient;
using ApiSDKClient.FApi.Request.Contraband;
using ApiSDKClient.FApi.Response.Contraband;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ContrabandBll
    {
        ContrabandDal dal = new ContrabandDal();
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public ContrabandResponse GetContrabands(ContrabandRequest name)
        {
            ContrabandResponse response = new ContrabandResponse();
            Contraband contraband = new Contraband()
            {
                ItemName = name.ItemName
            };
            return dal.GetContrabands(contraband);

        }

        

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public WaybillLnquiryResponse GetWaybillLnquiry(WaybillLnquiryRequest bh)
        {
            WaybillLnquiryResponse response = new WaybillLnquiryResponse();
            WaybillLnquiry waybillLnquiry = new WaybillLnquiry()
            {
                TrackingNumber = bh.TrackingNumber
            };

            return dal.GetWaybillLnquiry(bh);
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public StorageResponse GetStorage(BaseRequest request)
        {
            StorageResponse response = new StorageResponse();
            

            return dal.GetStorage(request);
        }
    }
}
