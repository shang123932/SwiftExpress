using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class ShowShippingResponse:BaseResponse
    {
        public List<ShippingInforModel> shiplist { get; set; }
    }
}
