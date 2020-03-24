using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Contraband
{
    public class AddWaybillLnquiryRequest:BaseRequest
    {
        public int WaybillId { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string TrackingNumber { get; set; }
        /// <summary>
        /// 货单id
        /// </summary>
        public int CargoId { get; set; }
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
        /// 运单备注
        /// </summary>
        public string TrackingRemark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreateId { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public int UpdateId { get; set; }
    }
}
