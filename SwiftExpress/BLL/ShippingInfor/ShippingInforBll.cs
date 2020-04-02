using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.FApi.Response.ShippingInfor;
using ApiSDKClient.ShippingInfor;
using DAL;
using MODEL;
namespace BLL
{
   public  class ShippingInforBll
    {
        ShippingInforDal dal = new ShippingInforDal();
        public ADDShippingInforResonse ADD(ADDShippingInforRequest ADDShippingInfor)
        {
            ADDShippingInforResonse response = new ADDShippingInforResonse();


            ShippingInforModel dis = new ShippingInforModel()
            {

              ShippingOrder= ADDShippingInfor.ShippingOrder1,
              ShippingName = ADDShippingInfor.ShippingName1,
              ShippingPhone = ADDShippingInfor.ShippingPhone1,
              ShippingAddress = ADDShippingInfor.ShippingAddress1,
              ReceiveName = ADDShippingInfor.ReceiveName1,
              ReceivePhone = ADDShippingInfor.ReceivePhone1,
              ReceiveAddress = ADDShippingInfor.ReceiveAddress1,
              ShippingRemark=ADDShippingInfor.ShippingRemark1,
            };
            var res = dal.ADD(dis);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "寄件成功";
            }
            else
            {
                response.Status = false;
                response.Message = "寄件失败";

            }
            return response;
        }
        public GetShippingInforResonse GetShippingInfor()
        {
            GetShippingInforResonse response = new GetShippingInforResonse();

            var list = dal.GetShippingInfor();
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

        
    }
}
