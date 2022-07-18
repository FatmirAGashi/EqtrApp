using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qtrApp.Api.ApiModels
{
    public class CitizensOutputModel : BaseOutputModel
    {
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}
