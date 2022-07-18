using qtrApp.Api.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Api.ApiModels

{
    public class DrivingLicensesOutputModel : BaseOutputModel
    {
        public Guid? LicenseNumber { get; set; }
        public string IssuingAuthority { get; set; }
        public string PhotoLocation { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public CitizensOutputModel Citizen { get; set; }

    }
}
