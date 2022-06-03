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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public Destination getById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tadd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TgetList()
        {
            return _destinationDal.getList();
        }

        public void Tupdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
