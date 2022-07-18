using EqtrApp.Api.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qtrApp.Api.ApiModels
{
    public class DrivingCategoryModel
    {
        public string CategoryCode { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public DrivingLicensesOutputModel DrivingLicense { get; set; }
    }
}
