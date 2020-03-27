using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class GetStorageResponse:BaseResponse
    {
        public List<Storage> Storagelist { get; set; }
    }
}
