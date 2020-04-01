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
    public class ShippingInfors
    {
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ShippingOrder { get; set; }
        /// <summary>
        /// 寄件姓名
        /// </summary>
        public string ShippingName { get; set; }
        /// <summary>
        /// 寄件联系方式
        /// </summary>
        public string ShippingPhone { get; set; }
        /// <summary>
        /// 寄件地址
        /// </summary>
        public string ShippingAddress { get; set; }
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string ReceiveName { get; set; }
        /// <summary>
        /// 收件联系方式
        /// </summary>
        public string ReceivePhone { get; set; }
        /// <summary>
        /// 收件地址
        /// </summary>
        public string ReceiveAddress { get; set; }
        /// <summary>
        /// 货物名称
        /// </summary>
        public string CargoName { get; set; }
        /// <summary>
        ///货物类型
        /// </summary>
        public int CargoType { get; set; }
        /// <summary>
        /// 货物重量
        /// </summary>
        public int CargoWeight { get; set; }
        /// <summary>
        /// 货物状态
        /// </summary>
        public int CargoState { get; set; }
    }
}
