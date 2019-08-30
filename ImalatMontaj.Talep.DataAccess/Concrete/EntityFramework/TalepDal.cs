using ImalatMontaj.Core.DataAccess.EntityFramework;
using ImalatMontaj.Talep.DataAccess.Abstract;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.Concrete.EntityFramework
{
    public class TalepDal : EntityRepositoryBase<Entities.Concrete.Talep, DataContext>, ITalepDal
    {
        public TalepDal(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
