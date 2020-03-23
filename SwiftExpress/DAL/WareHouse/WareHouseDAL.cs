﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MODEL.WareHouse;

namespace DAL.WareHouse
{
    /// <summary>
    /// 仓库   zrx 2020年3月22日19:02:08
    /// </summary>
   public class WareHouseDAL
    {
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <returns></returns>
        public int AddWareHouse(WareHouseInfo info)
        {
            string sql = $"insert into WareHouse values('{info.WareHouseName}',{info.WareHouseCapacity},'{info.WareHouseAddress}',{info.WareHouseStatus},'{info.WareHouseRemark}')"; 
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 获取一条仓库数据
        /// </summary>
        /// <returns></returns>
        public WareHouseInfo GetOneWareHouse(int pid)
        {
            string sql = $"select * from WareHouse where WareHouseId={pid}";
            return DBHelper.GetToList<WareHouseInfo>(sql)[0];
        }
        /// <summary>
        /// 保存仓库
        /// </summary>
        /// <returns></returns>
        public int SaveWareHouse(WareHouseInfo info)
        {
            string sql = $"update WareHouse set WareHouseName='{info.WareHouseName}',WareHouseCapacity={info.WareHouseCapacity},WareHouseStatus={info.WareHouseStatus} where WareHouseId={info.WareHouseId}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <returns></returns>
        public int DelWareHouse(int id)
        {
            string sql = $"update WareHouse set WareHouseStatus=0 where WareHouseId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        public List<WareHouseInfo> GetWareHouses()
        {
            string sql = $"select * from WareHouse";
            return DBHelper.GetToList<WareHouseInfo>(sql);
        }
    }
}