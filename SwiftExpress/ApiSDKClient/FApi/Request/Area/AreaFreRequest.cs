using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request
{
    public class AreaFreRequest:BaseRequest
    {
        public int did { get; set; }
        public override string GetApiName()
        {
            return "/api/Area/GetFre";
        }
    }
}
