using ApiSDKClient.FApi.Request.Cargo;
using ApiSDKClient.FApi.Response.Cargo;
using BLL.Cargo;
using MODEL.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers.Cargo
{
    public class CargoController : ApiController
    {
        CargoBLL cbll = new CargoBLL();
        /// <summary>
        /// 添加仓库   zrx  2020年3月24日14:43:15
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public CargoAddResponse AddCargo(CargoAddRequest request)
        {

            return cbll.AddCargo(request); 
        }
        /// <summary>
        /// 获取一条仓库数据
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public CargoGetOneResponse GetOneCargo(CargoGetOneRequest request)
        {
            return cbll.GetOneCargo(request);
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public CargoUpdateResponse SaveCargo(CargoAddRequest request)
        {
            return cbll.SaveCargo(request);
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public CargoDelResponse DelCargo(CargoDelRequest request)
        {
            return cbll.DelCargo(request);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public CargoGetResponse GetCargo()
        {
            return cbll.GetCargo();
        }
    }
}
