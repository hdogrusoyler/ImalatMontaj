using ImalatMontaj.Core.DataAccess;
using ImalatMontaj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImalatMontaj.Core.Business.BusinessLogic
{
    public class BusinessLogicBase<TEntity, IDALayer> : IBusinessLogic<TEntity>
        where TEntity : class, IEntity, new()
        where IDALayer : IEntityRepository<TEntity>
    {
        private IDALayer _iDALayer;

        public BusinessLogicBase(IDALayer iDALayer)
        {
            _iDALayer = iDALayer;
        }

        public TEntity GetById(int Id)
        {
            return _iDALayer.Get(c => c.Id == Id);
        }

        public List<TEntity> GetAll()
        {
            int page = 1;
            int pageSize = 0;
            return _iDALayer.GetList(null, null, page, pageSize, (qry) => qry.OrderByDescending(x => x.Id));
        }

        public void Add(TEntity entity)
        {
            _iDALayer.Add(entity);
        }
        public void Update(TEntity entity)
        {
            _iDALayer.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _iDALayer.Delete(entity);
        }
    }
}
