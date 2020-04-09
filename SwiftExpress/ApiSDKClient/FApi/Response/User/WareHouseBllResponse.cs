using MODEL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class WareHouseBllResponse:BaseResponse
    {
        public List<WareHouseId1> Id { get; set; }
    }
}
