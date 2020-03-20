using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class ShippingInforModel
    {
        public int ShippingId { get; set; } //编号
        public string ShippingOrder { get; set; } //快递单号
        public string ShippingName { get; set; } //寄件姓名
        public string ShippingPhone { get; set; } //寄件联系方式
        public string ShippingAddress { get; set; }//寄件地址
        public string ReceiveName { get; set; }//收件人姓名
        public int ReceivePhone { get; set; }   //收件联系方式
        public string ReceiveAddress { get; set; } //收件地址
    }
}
