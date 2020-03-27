using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class UpdateWaybillLnquiryRequest:BaseRequest
    {
        public int id { get; set; }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal FreightTotal { get; set; }
        /// <summary>
        /// 快递时间
        /// </summary>
        public DateTime TrackingDate { get; set; }
        /// <summary>
        /// 快递详情（到达地）
        /// </summary>
        public string TrackingDetails { get; set; }
        /// <summary>
        /// 物品状态   1待发货 2已发货3运输中4派送中5签收
        /// </summary>
        public int TrackingState { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        public override string GetApiName()
        {
            return "/api/Contraband/UpdateWaybillLnquiry";
        }
    }
}
