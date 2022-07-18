using EqtrApp.DataAccess.EntityModels;
using System;
using System.Collections.Generic;

namespace EqtrApp.EntityModels
{
    public partial class DrivingCategories : BaseEntity
    {
        public int Id { get; set; }
        public int? DrivingLicenseId { get; set; }
        public string CategoryCode { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}
