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
            string sql = string.Format("insert into Staff values('{0}','{1}','{2}',{3}','{4}','{5}','{6}','{7}','{8}')", m.StaffId,m.StaffName,m.StaffSex,m.StaffAge,m.StaffPhone,m.StaffDuty,m.StaffLoginTime,m.StaffStatus,m.StaffRemark);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查询
        public List<StaffModel> GetStaff()
        {
            string sql = "select * from Staff where StaffId=‘{}’";
            return DBHelper.GetToList<StaffModel>(sql);
        }
        //删除
        public int DelteStaff(int id)
        {
            string sql = $"update Staff set StaffStatus=0 where StaffId={id} ";
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
