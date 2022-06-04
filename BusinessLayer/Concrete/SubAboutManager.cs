using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

      
        public void Tadd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TgetList()
        {
            return _subAboutDal.getList();
        }

        public void Tupdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
