using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    /// <summary>
    /// 添加请求
    /// </summary>
    public class AddDistributionRequest : BaseRequest
    {
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ShippingOrder { get; set; }
        /// <summary>
        /// 员工id
        /// </summary>
        public int StaffId { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>
        public int WareHouseId { get; set; }
        /// <summary>
        /// 接货时间
        /// </summary>
        public DateTime PickTime { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime SendTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int SendState { get; set; }
        /// <summary>
        /// 配送备注
        /// </summary>
        public string SendRemark { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AddDistribution";
        }
    }
}
