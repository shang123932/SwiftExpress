﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Cargo
{
   public class CargoDelRequest:BaseRequest
    {
        public int id { get; set; }
        public override string GetApiName()
        {
            return "/api/Cargo/DelCargo";
        }
    }
}
