using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Staff
{
   public class UpdateStaffPwdRequest:BaseRequest
    {
        /// <summary>
        /// 员工密码
        /// </summary>
        public string spwd { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string sname { get; set; }

        public override string GetApiName()
        {
            return "/api/Staff/UpdateStaffPwd";
        }
    }
}
