using EqtrApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Services.Abtractions
{
    public interface ICitizenService
    {
        void Add(Citizens model);
        void Add(IEnumerable<Citizens> models);
        void Delete(int id);
        Citizens Get(int id);
        IEnumerable<Citizens> GetAll();
        void Update(Citizens model);
        void Update(IEnumerable<Citizens> models);
    }
}
