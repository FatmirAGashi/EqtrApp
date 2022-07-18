using EqtrApp.DataAccess.EntityModels;
using System;
using System.Collections.Generic;

namespace EqtrApp.EntityModels
{
    public partial class Citizen : BaseEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}
