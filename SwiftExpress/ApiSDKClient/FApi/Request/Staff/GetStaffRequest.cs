﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Staff
{
   public class GetStaffRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Contraband/GetWaybillLnquiry";
        }
    }
}
