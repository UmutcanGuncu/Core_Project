using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using BusinnesLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinnesLayer.Concrete
{
    public class ReferenceManager :IReferenceService
    {
        private readonly IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void TAdd(Reference t)
        {
            _referenceDal.Insert(t);
        }

        public void TDelete(Reference t)
        {
            _referenceDal.Delete(t);
        }

        public Reference TGetById(int id)
        {
            return _referenceDal.GetById(id);
        }

        public List<Reference> TGetListAll()
        {
            return _referenceDal.GetListAll();
        }

        public void TUpdate(Reference t)
        {
            _referenceDal.Update(t);
        }
    }
}
