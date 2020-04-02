using MODEL.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Staff
{
   public class GetStaffResponse:BaseResponse
    {
        public List<StaffModel> staff { get; set; }
    }
}
