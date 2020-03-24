using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.ShippingInfor
{
   public class ShippingInforRequest:BaseRequest
    {
     
    public override string GetApiName()
    {
        return "/api/Contraband/GetWaybillLnquiry";
    }
}
}
