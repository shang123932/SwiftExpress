using ApiSDKClient.FApi.Request.Staff;
using ApiSDKClient.FApi.Response.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class StaffBll
    {

        public ADDStaffResponse ADDStaff(ADDStaffRequest addRequest)
        {
            return ApiRequestHelper.Post<ADDStaffRequest, ADDStaffResponse>(addRequest);
        }
        public GetStaffResponse GetStaff(GetStaffRequest getRequest)
        {
            return ApiRequestHelper.Post<GetStaffRequest, GetStaffResponse>(getRequest);
        }
        public DelStaffResponse DelStaff(DelStaffRequest delRequest)
        {
            return ApiRequestHelper.Post<DelStaffRequest, DelStaffResponse>(delRequest);
        }
        public UpdateStaffResponse UpdateStaff(UpdateStaffRequest request)
        {
            return ApiRequestHelper.Post<UpdateStaffRequest, UpdateStaffResponse>(request);

        }
    }
}
