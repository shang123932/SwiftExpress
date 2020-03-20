using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 单例模式的实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseBLL<T> where T : new()
    {

        private static T _Instance;
        private BaseBLL() { }
        public static T getInstance()
        {
            if (_Instance == null)
            {
                lock (_Instance)
                {
                    if (_Instance == null)
                    {
                        _Instance = new T();
                    }
                }
            }
            return _Instance;
        }
    }
}
