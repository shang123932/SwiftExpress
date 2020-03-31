using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Cargo
{
   public class CargoInfo
    {
        /// <summary>
        /// 货物id
        /// </summary>
        public int CargoId { get; set; }
        /// <summary>
        /// 货物名称
        /// </summary>
        public string CargoName     { get; set; }
        /// <summary>
        /// 货物类型 1 货到付款  2即时快递  3普通快递  4礼品快递
        /// </summary>
        public int CargoType     { get; set; }
        /// <summary>
        /// 货物重量
        /// </summary>
        public int CargoWeight   { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ShippingOrder { get; set; }
        /// <summary>
        /// 货物状态 0 出库  1在库 2 待入库
        /// </summary>
        public int CargoState    { get; set; }
        /// <summary>
        /// 货物备注
        /// </summary>
        public string CargoRemark   { get; set; }
    }
}
