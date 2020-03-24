using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Staff
{
    public class StaffModel
    {
        public int StaffId { get; set; }
        public string  StaffName { get; set; }
        public int StaffSex                  { get; set; }
        public int StaffAge                 { get; set; }
        public string   StaffPhone             { get; set; }
        public int StaffDuty                { get; set; }
        public DateTime    StaffLoginTime     { get; set; }
        public int    StaffStatus           { get; set; }
        public string  StaffRemark            { get; set; }
    }
}
