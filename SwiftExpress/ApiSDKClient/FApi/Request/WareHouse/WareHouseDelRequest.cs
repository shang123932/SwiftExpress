using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.WareHouse
{
    public class WareHouseDelRequest :BaseRequest
    {
        public int id { get; set; }
        public override string GetApiName()
        {
            return "/api/WareHouse/DelWareHouse";
        }
    }
}
