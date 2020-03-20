using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public class BaseResponse
    {
        public bool IsRegistSuccess { get; set; }
        /// <summary>
        /// 状态为true表示接口请求成功
        /// </summary>
        public bool Status = true;
        /// <summary>
        /// 当状态失败时,提示消息
        /// </summary>
        public string Message { get; set; }
    }
}
