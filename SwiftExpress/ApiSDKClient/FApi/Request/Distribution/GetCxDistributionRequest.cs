﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class GetCxDistributionRequest:BaseRequest
    {
        public string ShippingOrder { get; set; }
        public override string GetApiName()
        {
            return "/api/User/GetCxDistribution";
        }
    }
}
