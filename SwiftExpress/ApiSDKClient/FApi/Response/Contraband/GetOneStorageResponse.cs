using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class GetOneStorageResponse:BaseResponse
    {
        public Storage storages { get; set; }
    }
}
