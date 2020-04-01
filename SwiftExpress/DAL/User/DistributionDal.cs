using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
namespace DAL
{
    /// <summary>
    /// 配送信息dal
    /// </summary>
   public class DistributionDal
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SwiftExpress;Integrated Security=True");
        /// <summary>
        /// 配送 显示 
        /// </summary>
        /// <returns></returns>
        public List<DistributionModel> GetDistribution()
        {
            string sql = $"select  * from  Distribution where SendState>=0 ";
            return DBHelper.GetToList<DistributionModel>(sql);
        }
        /// <summary>
        /// 查询配送
        /// </summary>
        /// <returns></returns>
        public List<DistributionModel> GetCxDistribution(string name)
        {      
             string   sql = $"select * from Distribution where ShippingOrder='{name}' and SendState>=0 ";        
            return DBHelper.GetToList<DistributionModel>(sql);
        }

        /// <summary>
        /// 配送 添加 
        /// </summary>
        /// <returns></returns>
        public int  AddDistribution(DistributionModel dis)
        {
            string sql = $"insert into Distribution(ShippingOrder,StaffId,WareHouseId,PickTime,SendTime,SendType,SendState,SendRemark,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values('{dis.ShippingOrder}','{dis.StaffId}','{dis.WareHouseId}','{dis.PickTime}','{dis.SendTime}','物流','{dis.SendState}','{dis.SendRemark}',1,GETDATE(),GETDATE(),1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        public int DeleteDistribution(int ids)
        {
            string sql = $"update Distribution set SendState=-1 where DistributionId={ids} and SendState=0 ";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取一条配送数据
        /// </summary>
        /// <returns></returns>
        public DistributionModel GetOneDistribution(int pid)
        {
        

            if (con.State == System.Data.ConnectionState.Closed)//判断打开
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from Distribution where DistributionId=" + pid;//语句

            var read = cmd.ExecuteReader();
            DistributionModel u = new DistributionModel();
            while (read.Read())//循环
            {

                u.ShippingOrder = read["ShippingOrder"].ToString();
                u.StaffId = Convert.ToInt32(read["StaffId"]);
                u.WareHouseId = Convert.ToInt32(read["WareHouseId"]);
                u.PickTime = Convert.ToDateTime(read["PickTime"]);
                u.SendTime = Convert.ToDateTime(read["SendTime"]);
                u.SendType = read["SendType"].ToString();

            }
            read.Read();
            con.Close();
            return u;
        }
        /// <summary>
        /// 修改配送信息
        /// </summary>
        /// <returns></returns>
        public int SaveDistribution(DistributionModel info)
        {
            string sql = $"update Distribution set StaffId='{info.StaffId}',WareHouseId={info.WareHouseId},UpdateTime=GETDATE(),UpdateId=1 where DistributionId={info.DistributionId}";
            return DBHelper.ExecuteNonQuery(sql);
        }


    }
}
