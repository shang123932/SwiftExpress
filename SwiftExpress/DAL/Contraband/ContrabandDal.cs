using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ContrabandDal
    {
        #region
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<Contraband> GetContrabands(string name)
        {
            string sql = "select * from Contraband";
            return DBHelper.GetToList<Contraband>(sql);
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<WaybillLnquiry> GetWaybillLnquiry(string bh)
        {
            string sql = "select * from WaybillLnquiry";
            return DBHelper.GetToList<WaybillLnquiry>(sql);
        }

        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <returns></returns>
        public int AddWaybillLnquiry(WaybillLnquiry w)
        {
            string sql = $"insert into WaybillLnquiry values('{w.FreightTotal}','{w.TrackingDate}',{w.TrackingDetails},'{w.TrackingState}','{w.TrackingRemark}',GETDATE(),GETDATE(),1,1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改运单信息
        /// </summary>
        /// <returns></returns>
        public int UpdateWaybillLnquiry(WaybillLnquiry w)
        {
            string sql = $"update WaybillLnquiry set FreightTotal='{w.FreightTotal}',TrackingDate='{w.TrackingDate}',TrackingDetails='{w.TrackingDetails}',TrackingState='{w.TrackingState}',TrackingRemark='{w.TrackingRemark}',CreateTime=GETDATE(),UpdateTime=GETDATE(),CreateId=1,UpdateId=1,Status=1 where WaybillId={w.WaybillId}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除运单信息
        /// </summary>
        /// <returns></returns>
        public int DeleteWaybillLnquiry(int id)
        {
            string sql = $"Update WaybillLnquiry set Status=0 where WaybillId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取一条运单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WaybillLnquiry GetOneWaybillLnquiry(int id)
        {
            string sql = $"select * from WaybillLnquiry where WaybillId={id} and status=1";
            return DBHelper.GetToList<WaybillLnquiry>(sql)[0];
        }
        #endregion

        #region 查询存储信息表一套
        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public List<Storage> GetStorage()
        {
            string sql = "";
            return DBHelper.GetToList<Storage>(sql);
        }
        #endregion
    }
}
