using ImalatMontaj.Core.DataAccess.EntityFramework;
using ImalatMontaj.Talep.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.Concrete.EntityFramework
{
    public class FotoDal : EntityRepositoryBase<Entities.Concrete.Foto, DataContext>, IFotoDal
    {
        public FotoDal(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
