using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class ContrabandRequest:BaseRequest
    {
        /// <summary>
        /// 违禁品
        /// </summary>
        public string ItemName { get; set; }
        public override string GetApiName()
        {
            return "/api/Contraband/GetContraband";
        }
    }
}
