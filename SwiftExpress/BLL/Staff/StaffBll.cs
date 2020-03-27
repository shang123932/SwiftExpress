﻿using ApiSDKClient.FApi.Request.Staff;
using ApiSDKClient.FApi.Response.Staff;
using DAL.Staff;
using MODEL.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Staff
{
   public class StaffBll
    {
        StaffDal dal = new StaffDal();
        public ADDStaffResponse ADDStaff(ADDStaffRequest request)
        {
            ADDStaffResponse response = new ADDStaffResponse();

            StaffModel cargo = new StaffModel()
            {
             
                StaffName= request.StaffName,
                
                StaffSex= request.StaffSex,
                StaffAge= request.StaffAge,
                StaffPhone= request.StaffPhone,
                StaffDuty= request.StaffDuty,
                StaffLoginTime= request.StaffLoginTime,
                StaffStatus= request.StaffStatus,
                StaffRemark= request.StaffRemark
            };
            //获取名不能为空
            if (request == null || string.IsNullOrEmpty(request.StaffName))
            {
                response.Status = false;
                response.Message = "货物名称不能为空";
                return response;
            }
            //获取名不能为空
            if (request.StaffAge == 0)
            {
                response.Status = false;
                response.Message = "年龄不能为空";
                return response;
            }
            //验证货物是否存在


            var res = dal.ADD(cargo);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加货物成功";
            }
            else
            {
                response.Status = false;
                response.Message = "添加货物失败";

            }

            return response;
        }


        /// <summary>
        /// 删除员工
        /// </summary>
        /// <returns></returns>
        public DelStaffResponse DelStaff(DelStaffRequest request)
        {
            DelStaffResponse response = new DelStaffResponse();

            var res = dal.DelteStaff(request.id);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "删除成功";
            }
            else
            {
                response.Status = false;
                response.Message = "删除失败";
                return response;
            }
            return response;
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public GetStaffResponse GetStaff()
        {
            GetStaffResponse response = new GetStaffResponse();

            var list = dal.GetStaff();
            if (list.Count <= 0)
            {
                response.Status = false;
                response.Message = "获取用户信息失败,请检查一下在弄";
            }
            else
            {
                response.Message = $"获取信息成功";
            }
            return response;
        }

    }
}
