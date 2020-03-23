using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Cargo;

namespace DAL.Cargo
{
    /// <summary>
    /// 货物  
    /// </summary>
   public class CargoDAL
    {
        /// <summary>
        /// 添加货物
        /// </summary>
        /// <returns></returns>
        public int AddCargo(CargoInfo info)
        {
            string sql = $"insert into Cargo values('{info.CargoName}',{info.CargoType},{info.CargoWeight},'{info.ShippingOrder}',{info.CargoState},'{info.CargoRemark}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 获取一条货物数据
        /// </summary>
        /// <returns></returns>
        public CargoInfo GetOneCargo(int pid)
        {
            string sql = $"select * from Cargo where CargoId=={pid}";
            return DBHelper.GetToList<CargoInfo>(sql)[0];
        }
        /// <summary>
        /// 保存货物
        /// </summary>
        /// <returns></returns>
        public int SaveCargo(CargoInfo info)
        {
            string sql = $"update Cargo set CargoName='{info.CargoName}',CargoType={info.CargoType},CargoWeight={info.CargoWeight},ShippingOrder='{info.ShippingOrder}',,CargoRemark='{info.CargoRemark}',CargoState= {info.CargoState} where CargoId={info.CargoId}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除货物
        /// </summary>
        /// <returns></returns>
        public int DelCargo(int id)
        {
            string sql = $"update Cargo set CargoState=0 where CargoId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示货物
        /// </summary>
        /// <returns></returns>
        public List<CargoInfo> GetCargo()
        {
            string sql = $"select * from Cargo";
            return DBHelper.GetToList<CargoInfo>(sql);
        }
        public int IsExistShipping(string ship)
        {
            string sql = $"select count(1) from Cargo where ShippingOrder={ship} and CargoState=1";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }
    }
}
