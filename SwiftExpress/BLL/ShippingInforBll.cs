using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;
namespace BLL
{
   public  class ShippingInforBll
    {
        ShippingInforDal dal = new ShippingInforDal();
        public int ADD(ShippingInforModel m)
        {
            return dal.ADD(m);
        }
        public List<ShippingInforModel> GetShippingInfor()
        {
            return dal.GetShippingInfor();
        }
    }
}
