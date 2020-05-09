using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class WareHouseBllRequest:BaseRequest
    {
      
        public override string GetApiName()
        {
            return "/api/User/WareHouseBllShow";
        }
    }
}
