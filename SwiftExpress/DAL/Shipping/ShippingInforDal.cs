using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL
{
    public class ShippingInforDal
    {
        public int ADD(ShippingInforModel m)
        {
            string sql = string.Format("insert into ShippingInfo values('{0}','{1}','{2}',{3}','{4}','{5}','{6}','{7}','{8}')", m.ShippingId, m.ShippingOrder, m.ShippingName, m.ShippingPhone, m.ShippingAddress, m.ReceiveName, m.ReceivePhone, m.ReceiveAddress,m.ShippingRemark);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<ShippingInforModel> GetShippingInfor()
        {
            string sql = "select * from ShippingInfor";
            return DBHelper.GetToList<ShippingInforModel>(sql);
        }

      /// <summary>
      /// 显示寄件
      /// </summary>
      /// <param name="name"></param>
      /// <returns></returns>
        public List<ShippingInforModel> ShowShipping(string name)
        {
            string sql = $"select * from ShippingInfo where ShippingName='{name}'";
            return DBHelper.GetToList<ShippingInforModel>(sql);
        }
    }
}
