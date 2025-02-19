using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Aplication.Interface.Base;
using AL.Manager.Domain.Interface.Base;
using AL.Manager.Infra.Data.Repositories.Base;

namespace AL.Manager.Aplication.Services.Base
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        
        public void Create(TEntity entity)
        {
            _repository.Create(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _repository.GetAll();
        }
    }
}