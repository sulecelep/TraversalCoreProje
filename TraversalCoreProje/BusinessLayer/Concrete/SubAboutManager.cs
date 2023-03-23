using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public List<SubAbout> GetByFilter(Expression<Func<SubAbout, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubAbout t)
        {
            _subAboutDal.Insert(t);
        }

        public void TDelete(SubAbout t)
        {
            _subAboutDal.Delete(t); 
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
