using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request
{
   public class AreaCityRequest:BaseRequest
    {
        public int pid { get; set; }
        public override string GetApiName()
        {
            return "/api/Area/GetCity";
        }
    }
}
