using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace ApiSDKClient
{
    public class GetShippingInforResponse:BaseResponse
    {
        public ShippingInfors ShippingInforlist { get; set; }
    }
}
