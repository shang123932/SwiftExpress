using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.WareHouse
{
    /// <summary>
    /// 仓库信息表 
    /// </summary>
    public class WareHouseInfo
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        public int  WareHouseId       { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string  WareHouseName     { get; set; }
        /// <summary>
        /// 仓库容量
        /// </summary>
        public int  WareHouseCapacity { get; set; }
        /// <summary>
        /// 仓库地址
        /// </summary>
        public string  WareHouseAddress  { get; set; }
        /// <summary>
        /// 仓库状态 0弃用  1正在使用 2备选（新增）  
        /// </summary>
        public int  WareHouseStatus   { get; set; }
        /// <summary>
        /// 仓库备注
        /// </summary>
        public string  WareHouseRemark { get; set; }
    }
}
