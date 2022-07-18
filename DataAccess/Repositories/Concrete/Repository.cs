using EqtrApp.DataAccess.EntityModels;
using EqtrApp.DataAccess.Repositories.Abstractions;
using EqtrApp.Domain;
using EqtrApp.EntityModels;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace EqtrApp.DataAccess.Repositories.Concrete
{
    public class Repository<TDomain, TEntity> : IRepository<TDomain> where TDomain : BaseModel where TEntity : BaseEntity
    {
        protected EqtrContext Context;
        public Repository(EqtrContext eqtrContext)
        {
            Context = eqtrContext;
        }
        public void Add(TDomain model)
        {
            var entity = model.Adapt<TEntity>();
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Add(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Add(model);
            }
        }

        public virtual void Delete(int id)
        {
            var entity = Context.Set<TEntity>().FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return;
            }
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual TDomain Get(int id)
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var entity = query.FirstOrDefault(x => x.Id == id);
            var model = entity.Adapt<TDomain>();

            return model;
        }

        public virtual IEnumerable<TDomain> GetAll()
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var models = query.Adapt<IEnumerable<TDomain>>(); 

            return models;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Update(TDomain model)
        {
            var entityModel = model.Adapt<TEntity>();
            Context.Set<TEntity>().Attach(entityModel);
            Context.SaveChanges();
        }

        public virtual void Update(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Update(model);
            };
        }

    }
}
