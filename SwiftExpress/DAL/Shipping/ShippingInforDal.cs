using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


        public List<ShippingInforModel> ShowShipping(string name)
        {
        
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=SwiftExpress;Integrated Security=True");
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            var table = new List<ShippingInforModel>();
            string sql = $"select * from ShippingInfo where ShippingName='{name}'";
            SqlCommand comm = new SqlCommand(sql, connection);
            var res = comm.ExecuteReader();
            while (res.Read())
            {
                ShippingInforModel shipping = new ShippingInforModel()
                {
                    ShippingOrder = Convert.ToString(res["ShippingOrder"]),
                    ShippingName = Convert.ToString(res["ShippingName"]),
                    ShippingPhone = Convert.ToString(res["ShippingPhone"]),
                     ShippingAddress = Convert.ToString(res["ShippingAddress"]),
                    ReceiveName = Convert.ToString(res["ReceiveName"]),
                    ReceivePhone =Convert.ToString( res["ReceivePhone"]),
                    ReceiveAddress = Convert.ToString(res["ReceiveAddress"]),
                };
                table.Add(shipping);
            }
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }


            return table;
        }
    }
}
