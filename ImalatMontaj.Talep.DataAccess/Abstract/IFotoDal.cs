using ImalatMontaj.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.Abstract
{
    public interface IFotoDal : IEntityRepository<Entities.Concrete.Foto>
    {
        //custom operations
    }
}
