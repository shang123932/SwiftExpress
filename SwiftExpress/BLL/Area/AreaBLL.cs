using MODEL.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Area;

namespace BLL.Area
{
    /// <summary>
    /// 地区BLL
    /// </summary>
   public class AreaBLL
    {
        #region  zrx 2020年3月20日13:10:17
        AreaDal areaDal = new AreaDal();
        /// <summary>
        /// 获取省份
        /// </summary>
        /// <returns></returns>
        public List<AreaModel> GetProvince()
        {
            return areaDal.GetProvince();
        }
        /// <summary>
        /// 获取城市、区、县
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<AreaModel> GetCity(int pid)
        {
            return areaDal.GetCity(pid);
        }
        #endregion
    }
}
