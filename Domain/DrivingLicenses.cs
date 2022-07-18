using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Domain
{
    public class DrivingLicenses : BaseModel
    {
        public Guid? LicenseNumber { get; set; }
        public string IssuingAuthority { get; set; }
        public string PhotoLocation { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public Citizens Citizen { get; set; }

    }
}
