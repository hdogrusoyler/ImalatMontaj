using ImalatMontaj.Core.DataAccess;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.Abstract
{
    public interface ITalepDal : IEntityRepository<Entities.Concrete.Talep>
    {
        //custom operations
    }
}
