using ImalatMontaj.Core.DataAccess;
using ImalatMontaj.Talep.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.UnitOfWork.Abstract
{
    public interface IEFUnitOfWork : IUnitOfWork
    {
        ITalepDal talepDal { get; set; }
        IFotoDal fotoDal { get; set; }
    }
}
