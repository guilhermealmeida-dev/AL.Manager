using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace AL.Manager.Domain.Interface.Base
{
    public interface IRepository<TEntity>
    {
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public IEnumerable<TEntity> GetAll();
        public TEntity? GetById(Guid id);
    }
}