using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class UpdateDistributionRequest:BaseRequest
    {
        /// <summary>
        /// 配送id
        /// </summary>
        public int DistributionId { get; set; }
        /// <summary>
        /// 员工id
        /// </summary>
        public int StaffId { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>
        public int WareHouseId { get; set; }
        public override string GetApiName()
        {
            return "/api/User/GetDistribution";
        }
    }
}
