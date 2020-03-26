using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class GetWaybillLnquiryRequest : BaseRequest
    {
        /// <summary>
        /// 运单号
        /// </summary>
        public string TrackingNumber { get; set; }
        public override string GetApiName()
        {
            return "/api/Contraband/GetWaybillLnquiry";
        }
    }
}
