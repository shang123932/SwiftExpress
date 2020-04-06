using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ContrabandDal
    {
        # region 违禁物品
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<Contraband> GetContrabands(string name)
        {
            string sql = "select * from Contraband";
            return DBHelper.GetToList<Contraband>(sql);
        }
        #endregion


        #region 运单一套
        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public List<WaybillLnquiry> GetWaybillLnquiry(string bh)
        {
            string sql = "select * from WaybillLnquiry  where Status=1";
            return DBHelper.GetToList<WaybillLnquiry>(sql);
        }

        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <returns></returns>
        public int AddWaybillLnquiry(WaybillLnquiry w)
        {
            string sql = $"insert into WaybillLnquiry values('{w.FreightTotal}','{w.TrackingDate}',{w.TrackingDetails},'{w.TrackingState}','{w.TrackingRemark}',GETDATE(),GETDATE(),1,1,1)";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改运单信息
        /// </summary>
        /// <returns></returns>
        public int UpdateWaybillLnquiry(WaybillLnquiry w)
        {
            string sql = $"update WaybillLnquiry set FreightTotal='{w.FreightTotal}',TrackingDate='{w.TrackingDate}',TrackingDetails='{w.TrackingDetails}',TrackingState='{w.TrackingState}',TrackingRemark='{w.TrackingRemark}',CreateTime=GETDATE(),UpdateTime=GETDATE(),CreateId=1,UpdateId=1,Status=1 where WaybillId={w.WaybillId}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除运单信息
        /// </summary>
        /// <returns></returns>
        public int DeleteWaybillLnquiry(int id)
        {
            string sql = $"Update WaybillLnquiry set Status=0 where WaybillId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取一条运单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WaybillLnquiry GetOneWaybillLnquiry(int id)
        {
            string sql = $"select * from WaybillLnquiry where WaybillId={id} and status=1";
            return DBHelper.GetToList<WaybillLnquiry>(sql)[0];
        }
        #endregion
        /// <summary>
        /// 运单查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ShippingInfors GetShippingInfor(string name)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=SwiftExpress;Integrated Security=True");
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            var table = new ShippingInfors();
            string sql = $"select * from ShippingInfo  s join Cargo c on s.ShippingOrder=c.ShippingOrder where s.ShippingOrder='{name}'";
            SqlCommand comm = new SqlCommand(sql,connection);
            var res = comm.ExecuteReader();
            while (res.Read())
            {
                ShippingInfors shipping = new ShippingInfors()
                {
                    CargoName = Convert.ToString(res["CargoName"]),
                    CargoState = Convert.ToInt32(res["CargoState"]),
                    CargoType = Convert.ToInt32(res["CargoType"]),
                    CargoWeight = Convert.ToInt32(res["CargoWeight"]),
                    ReceiveAddress = Convert.ToString(res["ReceiveAddress"]),
                    ReceiveName = Convert.ToString(res["ReceiveName"]),
                    ReceivePhone = Convert.ToString(res["ReceivePhone"]),
                    ShippingAddress = Convert.ToString(res["ShippingAddress"]),
                    ShippingName = Convert.ToString(res["ShippingName"]),
                    ShippingOrder = Convert.ToString(res["ShippingOrder"]),
                    ShippingPhone = Convert.ToString(res["ShippingPhone"])
                };
                table = shipping;
            }
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

           
            return table;
        }

        #region 存储信息表一套
        /// <summary>
        /// 查询存储号查看信息
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public List<Storage> GetStorage()
        {
            string sql = @"select * from Storage s where s.Status=1";
            //s
            //            join Cargo c on s.CargoId = c.CargoId
            //            join WareHouse w on s.WareHouseId = w.WareHouseId
            //            join Staff f on s.StaffId = f.StaffId";
            return DBHelper.GetToList<Storage>(sql);
        }

        /// <summary>
        /// 添加存储信息
        /// </summary>
        /// <returns></returns>
        public int AddStorage(Storage w)
        {
            string sql = $"insert into Storage values({w.CargoId},{w.WareHouseId},{w.StaffId},'{w.InStorageTime}',{w.InStorageNumber},'{w.OutStorageTime}',{w.OutStorageNumber},GETDATE(),GETDATE(),1,1,1,'{w.Remark}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改存储信息
        /// </summary>
        /// <returns></returns>
        public int UpdateStorage(Storage w)
        {
            string sql = $"update Storage set CargoId={w.CargoId},WareHouseId={w.WareHouseId},StaffId={w.StaffId},InStorageTime='{w.InStorageTime}',InStorageNumber='{w.InStorageNumber}',OutStorageTime='{w.OutStorageTime}',OutStorageNumber='{w.OutStorageNumber}',CreateTime=GETDATE(),UpdateTime=GETDATE(),CreateId=1,UpdateId=1,Status=1,Remark='{w.Remark}' where StorageId={w.StorageId}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除存储信息
        /// </summary>
        /// <returns></returns>
        public int DeleteStorage(int id)
        {
            string sql = $"Update Storage set Status=0 where StorageId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取一条存储信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Storage GetOneStorage(int id)
        {
            string sql = $"select * from Storage where StorageId={id} and status=1";
            return DBHelper.GetToList<Storage>(sql)[0];
        }



        #endregion
    }
}
