using ImalatMontaj.Core.DataAccess.UnitOfWork;
using ImalatMontaj.Talep.DataAccess.Abstract;
using ImalatMontaj.Talep.DataAccess.Concrete.EntityFramework;
using ImalatMontaj.Talep.DataAccess.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.UnitOfWork.Concrete
{
    public class EFUnitOfWork : UnitOfWorkBase<DataContext>, IEFUnitOfWork
    {
        public ITalepDal talepDal { get; set; }
        public IFotoDal fotoDal { get; set; }

        public EFUnitOfWork(DataContext context, ITalepDal _talepDal, IFotoDal _fotoDal) : base(context)
        {
            talepDal = _talepDal;
            fotoDal = _fotoDal;
        }

    }
}
