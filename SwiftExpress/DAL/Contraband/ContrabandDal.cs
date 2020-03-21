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
        /// 查询存储信息表
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public List<Storage> GetStorage()
        {
            string sql = "";
            return DBHelper.GetToList<Storage>(sql);
        }
    }
}
