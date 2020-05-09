using MODEL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class WareHouseId2
    {
        /// <summary>
        ///显示仓库下拉 
        /// </summary>
        /// <returns></returns>
        public List<WareHouseId1> WareHouseIdss()
        {
            string sql = $"select  * from WareHouse";
            return DBHelper.GetToList<WareHouseId1>(sql);
        }
    }
}
