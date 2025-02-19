using System;

namespace AL.Manager.Aplication.Interface.Base;

public interface IService<TEntity>
{
    void Create(TEntity entity);
    IEnumerable<TEntity>GetAll();
}
