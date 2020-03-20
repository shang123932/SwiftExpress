using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Area
{
   public class AreaProvinceRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Area/GetProvince";
        }
    }
}
