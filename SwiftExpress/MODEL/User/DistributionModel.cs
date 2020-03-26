using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 配送信息表sxx
    /// </summary>
   public class DistributionModel
    {
        /// <summary>
        /// 配送id
        /// </summary>
        public int DistributionId { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ShippingOrder  { get; set; }
        /// <summary>
        /// 员工id
        /// </summary>
        public int StaffId        { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>
        public int WareHouseId    { get; set; }
        /// <summary>
        /// 接货时间
        /// </summary>
        public DateTime PickTime       { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime SendTime       { get; set; }
        /// <summary>
        /// 配送方式
        /// </summary>
        public string SendType       { get; set; }
        /// <summary>
        /// 货物状态 0配送完毕  1配送中 2 待配送
        /// </summary>
        public int SendState      { get; set; }
        /// <summary>
        /// 配送备注
        /// </summary>
        public string SendRemark { get; set; }
        ///// <summary>
        ///// 状态 1正常-1删除
        ///// </summary>
        //public int Status { get; set; }
        ///// <summary>
        ///// 
        ///// 创建时间
        ///// </summary>
        //public DateTime CreateTime { get; set; }
        ///// <summary>
        ///// 修改时间
        ///// </summary>
        //public DateTime UpdateTime { get; set; }
        ///// <summary>
        ///// 创建人id
        ///// </summary>
        //public int CreateId { get; set; }
        ///// <summary>
        ///// 修改人id
        ///// </summary>
        //public int UpdateId { get; set; }


    }
}
