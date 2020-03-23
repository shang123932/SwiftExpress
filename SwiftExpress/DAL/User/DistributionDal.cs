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
        /// 配送  
        /// </summary>
        /// <returns></returns>
        public List<DistributionModel> GetDistribution()
        {
            string sql = $"select  * from  Distribution";
            return DBHelper.GetToList<DistributionModel>(sql);
        }
    }
}
