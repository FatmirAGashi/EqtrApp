using EqtrApp.DataAccess.Repositories.Abstractions;
using EqtrApp.Domain;
using EqtrApp.Services.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Services.Concrete
{
    public class CitizensServices : ICitizenService
    {
        private readonly ICitizenRepository _repository;
        public CitizensServices(ICitizenRepository repository)
        {
            _repository = repository;
        }

        public void Add(Citizens model)
        {
            _repository.Add(model);
        }

        public void Add(IEnumerable<Citizens> models)
        {
            _repository.Add(models);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Citizens Get(int id)
        {
            var model = _repository.Get(id);

            return model;
        }

        public IEnumerable<Citizens> GetAll()
        {
            var models = _repository.GetAll();

            return models;
        }

        public void Update(Citizens model)
        {
            _repository.Update(model);
        }

        public void Update(IEnumerable<Citizens> models)
        {
            _repository.Update(models);
        }

    }
}
