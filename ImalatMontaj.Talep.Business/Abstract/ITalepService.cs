using ImalatMontaj.Core.Business;
using ImalatMontaj.Core.Entities;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.Business.Abstract
{
    public interface ITalepUnitService
    {
        Entities.Concrete.Talep GetById(int Id);
        List<Entities.Concrete.Talep> GetAll();
        void Add(Entities.Concrete.Talep entity);
        void Update(Entities.Concrete.Talep entity);
        void Delete(Entities.Concrete.Talep entity);
    }

    public interface ITalepService : IBusinessLogic<Entities.Concrete.Talep>
    {
        
    }
}
