using MODEL.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Area
{
   public  class AreaDal
    {
        public List<AreaModel> GetAreas(int pid)
        {
            string sql = $"select  * from  Areatable where PId={pid}";
            List<AreaModel> list = new List<AreaModel>();
            return list;
        }
    }
}
