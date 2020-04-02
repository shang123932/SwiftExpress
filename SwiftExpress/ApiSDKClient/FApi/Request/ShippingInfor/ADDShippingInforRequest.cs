using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.ShippingInfor
{
  public class ADDShippingInforRequest:BaseRequest
    {

        public string ShippingOrder1 { get; set; } //快递单号
        public string ShippingName1 { get; set; } //寄件姓名
        public string ShippingPhone1 { get; set; } //寄件联系方式
        public string ShippingAddress1 { get; set; }//寄件地址
        public string ReceiveName1 { get; set; }//收件人姓名
        public int ReceivePhone1 { get; set; }   //收件联系方式
        public string ReceiveAddress1 { get; set; } //收件地址
        public string ShippingRemark1 { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AddShipp";
        }
    }
}
