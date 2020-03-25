using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Area;

namespace ApiSDKClient.FApi.Response.Area
{
   public class AreaProvinceResponse:BaseResponse
    {
        public List<AreaModel> arealist { get; set; }
    }
}
