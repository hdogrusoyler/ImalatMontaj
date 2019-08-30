using ImalatMontaj.Core.Business.BusinessLogic;
using ImalatMontaj.Talep.Business.Abstract;
using ImalatMontaj.Talep.DataAccess.Abstract;
using ImalatMontaj.Talep.DataAccess.UnitOfWork.Abstract;
using ImalatMontaj.Talep.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImalatMontaj.Talep.Business.Concrete
{
    public class TalepUnitManager : ITalepUnitService
    {
        private IEFUnitOfWork _unitOfWork;

        public TalepUnitManager(IEFUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Entities.Concrete.Talep> GetAll()
        {
            return _unitOfWork.talepDal.GetList();
        }

        public Entities.Concrete.Talep GetById(int Id)
        {
            return _unitOfWork.talepDal.Get(c => c.Id == Id);
        }

        public void Add(Entities.Concrete.Talep entity)
        {
            _unitOfWork.talepDal.Add(entity);
            _unitOfWork.Save();
        }

        public void Update(Entities.Concrete.Talep entity)
        {
            _unitOfWork.talepDal.Update(entity);
            _unitOfWork.Save();
        }

        public void Delete(Entities.Concrete.Talep entity)
        {
            _unitOfWork.talepDal.Delete(entity);
            _unitOfWork.Save();
        }
    }

    public class TalepManager : BusinessLogicBase<Entities.Concrete.Talep, ITalepDal>, ITalepService
    {
        public TalepManager(ITalepDal iTalepDal) : base(iTalepDal)
        {

        }
    }
}
