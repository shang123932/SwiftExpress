using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Contraband
{
   public  class GetOneWaybillLnquiryRequest:BaseRequest
    {
        public int id { get; set; }
        public override string GetApiName()
        {
            return "/api/Contraband/GetOneWaybillLnquiry";
        }
    }
}
