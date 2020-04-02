using MODEL.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Staff
{
   public class StaffDal
    {
        public int ADD(StaffModel m)
        {
            string sql = string.Format($"insert into  Staff(StaffName,StaffSex,StaffAge,StaffPhone,StaffDuty,StaffLoginTime,StaffStatus,StaffRemark,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values('{m.StaffName}','{m.StaffSex}','{m.StaffAge}','{m.StaffPhone}','{m.StaffDuty}','{m.StaffLoginTime}','1','{m.StaffRemark}',1,GETDATE(),GETDATE(),1,1)");
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查询
        public List<StaffModel> GetStaff()
        {
            string sql = "select * from Staff where StaffStatus=1 ";
            return DBHelper.GetToList<StaffModel>(sql);
        }
        //删除
        public int DelteStaff(int id)
        {
            string sql = $"update Staff set StaffStatus=0 where StaffId={id} and StaffStatus=1 ";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改
        public int UpdateStaff(StaffModel m )
        {
            string sql =$"update Staff set StaffName ='{m.StaffName}',StaffSex='{m.StaffSex}',StaffAge='{m.StaffAge}', StaffPhone='{m.StaffPhone},StaffDuty='{m.StaffDuty}',StaffLoginTime ='{m.StaffLoginTime}',StaffStatus='{m.StaffStatus}',StaffRemark='{m.StaffRemark}'where  StaffId =‘{m.StaffId}’";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
