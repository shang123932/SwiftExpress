using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ContrabandBll
    {
        ContrabandDal dal = new ContrabandDal();
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<Contraband> GetContrabands(string name)
        {
            return dal.GetContrabands(name);
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<WaybillLnquiry> GetWaybillLnquiry(string bh)
        {
            return dal.GetWaybillLnquiry(bh);
        }
    }
}
