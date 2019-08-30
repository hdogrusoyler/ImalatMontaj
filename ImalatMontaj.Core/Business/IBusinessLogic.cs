using ImalatMontaj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Core.Business
{
    public interface IBusinessLogic<TEntity> where TEntity : class, IEntity, new()
    {
        TEntity GetById(int Id);
        List<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
