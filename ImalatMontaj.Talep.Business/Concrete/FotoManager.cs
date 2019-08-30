using ImalatMontaj.Core.Business.BusinessLogic;
using ImalatMontaj.Talep.Business.Abstract;
using ImalatMontaj.Talep.DataAccess.Abstract;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImalatMontaj.Talep.Business.Concrete
{
    public class FotoManager : BusinessLogicBase<Entities.Concrete.Foto, IFotoDal>, IFotoService
    {
        private IFotoDal _iFotoDal;
        public FotoManager(IFotoDal iFotoDal) : base(iFotoDal)
        {
            _iFotoDal = iFotoDal;
        }

        public List<Foto> GetByTalep(int talepId)
        {
            int page = 1;
            int pageSize = 0;
            return _iFotoDal.GetList(f => f.TalepId == talepId, null, page, pageSize, (qry) => qry.OrderByDescending(x => x.Id));
        }
    }
}
