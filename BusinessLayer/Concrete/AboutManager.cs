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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
       

        public void Tadd(About t)
        {
            _aboutDal.insert(t);
        }

        public void Tdelete(About t)
        {
            _aboutDal.delete(t);
        }

        public About TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TgetList()
        {
            return _aboutDal.getList();
        }

        public void Tupdate(About t)
        {
            _aboutDal.update(t);
        }
    }
}
