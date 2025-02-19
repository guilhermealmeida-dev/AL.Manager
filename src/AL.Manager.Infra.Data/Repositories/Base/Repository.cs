using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Interface.Base;
using AL.Manager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AL.Manager.Infra.Data.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal readonly ApplicationDbContext _context;
        public DbSet<TEntity> Entities { get; }


        public Repository(ApplicationDbContext context)
        {
            _context = context;
            Entities = _context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            Entities.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                var entities = Entities.ToList<TEntity>();
                if (entities == null || !entities.Any())
                {
                    throw new Exception("Nenhuma entidade encontrada.");
                }
                return entities;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all entities", ex);
            }
        }


        public TEntity? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}