using EqtrApp.Domain;
using EqtrApp.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.DataAccess.Repositories.Concrete
{
    public class CitizenRepository : Repository<Citizens, Citizen>
    {
        public CitizenRepository(EqtrContext eqtrContext) : base(eqtrContext)
        {

        }
    }
}
