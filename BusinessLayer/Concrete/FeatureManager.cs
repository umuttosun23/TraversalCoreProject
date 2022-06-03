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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature getById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tadd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TgetList()
        {
            return _featureDal.getList();
        }

        public void Tupdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
