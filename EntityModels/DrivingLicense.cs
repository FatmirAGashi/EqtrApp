using EqtrApp.DataAccess.EntityModels;
using System;
using System.Collections.Generic;

namespace EqtrApp.EntityModels
{
    public partial class DrivingLicense : BaseEntity
    {
        public int Id { get; set; }
        public int? CitizenId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string IssuingAuthority { get; set; }
        public string PhotoLocation { get; set; }
        public Guid? LicenseNumber { get; set; }
    }
}
