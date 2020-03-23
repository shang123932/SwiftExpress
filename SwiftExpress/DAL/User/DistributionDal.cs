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
            string sql = $"select  * from  Distribution";
            return DBHelper.GetToList<DistributionModel>(sql);
        }

        /// <summary>
        /// 配送 添加 
        /// </summary>
        /// <returns></returns>
        public int  AddDistribution(DistributionModel dis)
        {
            string sql = $"insert into Distribution(ShippingOrder,StaffId,WareHouseId,PickTime,SendTime,SendType,SendState,SendRemark) values('{dis.ShippingOrder}','{dis.StaffId}','{dis.WareHouseId}','{dis.PickTime}','{dis.SendTime}','{dis.SendType}','{dis.SendState}','{dis.SendRemark}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        public int DeleteDistribution(int ids)
        {
            string sql = $"delete  * from  Distribution where DistributionId='{ids}'";
            return DBHelper.ExecuteNonQuery(sql);
        }


    }
}
