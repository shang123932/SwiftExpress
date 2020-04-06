using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.ShippingInfor
{
    public class ShowShippingRequest:BaseRequest
    {
        public string  Sname { get; set; }
        public override string GetApiName()
        {
            return "/api/Shipping/ShowShipping";
        }
    }
}
