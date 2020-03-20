using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 运单查询表
    /// </summary>
    public class WaybillLnquiry
    {
        /// <summary>
        /// 运单id
        /// </summary>
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
    }
}
