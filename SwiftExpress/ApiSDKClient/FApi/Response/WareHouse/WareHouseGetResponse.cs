﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.WareHouse;

namespace ApiSDKClient.FApi.Response.WareHouse
{
    public class WareHouseGetResponse : BaseResponse
    {
        public List<WareHouseInfo> wareahouselist { get; set; }
    }
}
