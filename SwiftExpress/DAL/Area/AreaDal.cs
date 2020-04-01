using MODEL.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Area
{
    /// <summary>
    /// 地区dal
    /// </summary>
   public  class AreaDal
    {
        #region zrx  2020年3月20日13:07:16
        /// <summary>
        /// 获取省份   
        /// </summary>
        /// <returns></returns>
        public List<AreaModel> GetProvince()
        {
            string sql = $"select  * from  Areatable where PId=0";
            return DBHelper.GetToList<AreaModel>(sql);
        }
        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<AreaModel> GetCity(int pid)
        {
            string sql = $"select  * from  Areatable where PId={pid}";
            return DBHelper.GetToList<AreaModel>(sql);
        }

        public int GetFre(int did)
        {
            string sql = $"select DId from Areatable where SId={did}";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }

        #endregion
    }
}
