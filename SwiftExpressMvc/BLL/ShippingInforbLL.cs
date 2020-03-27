﻿using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.FApi.Response.ShippingInfor;
using ApiSDKClient.ShippingInfor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ShippingInforBll
    {
        public ADDShippingInforResonse ADDShippingInfor(ADDShippingInforRequest addRequest)
        {
            return ApiRequestHelper.Post<ADDShippingInforRequest, ADDShippingInforResonse>(addRequest);
        }
        public GetShippingInforResonse CargoGet(ShippingInforRequest getRequest)
        {
            return ApiRequestHelper.Post<ShippingInforRequest, GetShippingInforResonse>(getRequest);
        }

    }
}
