using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Domain
{
    public class DrivingCategory : BaseModel
    {
        public string CategoryCode { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public DrivingLicenses DrivingLicense { get; set; }
    }
}
