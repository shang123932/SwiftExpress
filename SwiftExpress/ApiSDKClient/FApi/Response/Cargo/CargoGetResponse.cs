﻿using MODEL.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Cargo
{
   public class CargoGetResponse:BaseResponse
    { 
    
        public List<CargoInfo> list { get; set; }
    }
}
