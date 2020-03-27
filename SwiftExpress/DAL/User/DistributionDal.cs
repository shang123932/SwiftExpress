using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 配送信息dal
    /// </summary>
   public class DistributionDal
    {
        /// <summary>
        /// 配送 显示 
        /// </summary>
        /// <returns></returns>
        public List<DistributionModel> GetDistribution()
        {
            string sql = $"select  * from  Distribution where SendState=1";
            return DBHelper.GetToList<DistributionModel>(sql);
        }
        /// <summary>
        /// 查询配送
        /// </summary>
        /// <returns></returns>
        public List<DistributionModel> GetCxDistribution(string name)
        {
            string sql = $"select * from Distribution where ShippingOrder='{name}' and Status=1";
            return DBHelper.GetToList<DistributionModel>(sql);
        }

        /// <summary>
        /// 配送 添加 
        /// </summary>
        /// <returns></returns>
        public int  AddDistribution(DistributionModel dis)
        {
            string sql = $"insert into Distribution(ShippingOrder,StaffId,WareHouseId,PickTime,SendTime,SendType,SendState,SendRemark,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values('{dis.ShippingOrder}','{dis.StaffId}','{dis.WareHouseId}','{dis.PickTime}','{dis.SendTime}','物流',1,'{dis.SendRemark}',1,GETDATE(),GETDATE(),1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        public int DeleteDistribution(int ids)
        {
            string sql = $"update Distribution set SendState=0 Status=0 where DistributionId={ids}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取一条配送数据
        /// </summary>
        /// <returns></returns>
        public DistributionModel GetOneDistribution(int pid)
        {
            string sql = $"select * from Distribution where DistributionId={pid} and Status=1";
            return DBHelper.GetToList<DistributionModel>(sql)[0];
        }
        /// <summary>
        /// 修改配送信息
        /// </summary>
        /// <returns></returns>
        public int SaveDistribution(DistributionModel info)
        {
            string sql = $"update Distribution set StaffId='{info.StaffId}',WareHouseId={info.WareHouseId},UpdateTime=GETDATE(),UpdateId=1 where DistributionId={info.DistributionId}";
            return DBHelper.ExecuteNonQuery(sql);
        }


    }
}
