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
      
        public void Tadd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TgetById(int id)
        {
            return _destinationDal.getByID(id);
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
