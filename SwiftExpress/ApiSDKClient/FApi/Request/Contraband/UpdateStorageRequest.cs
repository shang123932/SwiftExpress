using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class UpdateStorageRequest:BaseRequest
    {
        /// <summary>
        /// 存储id 
        /// </summary>
        public int StorageId { get; set; }
        /// <summary>
        /// 货物id
        /// </summary>
        public int CargoId { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>
        public int WareHouseId { get; set; }
        /// <summary>
        /// 员工id
        /// </summary>
        public int StaffId { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InStorageTime { get; set; }
        /// <summary>
        /// 入库数量
        /// </summary>
        public int InStorageNumber { get; set; }
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime OutStorageTime { get; set; }
        /// <summary>
        /// 出库数量
        /// </summary>
        public int OutStorageNumber { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        public int Id { get; set; }

        public override string GetApiName()
        {
            return "/api/Contraband/UpdateStorage";
        }
    }
}
