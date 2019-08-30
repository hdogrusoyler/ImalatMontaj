using ImalatMontaj.Core.Business;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.Business.Abstract
{
    public interface IFotoService : IBusinessLogic<Entities.Concrete.Foto>
    {
        List<Foto> GetByTalep(int talepId);
    }
}
