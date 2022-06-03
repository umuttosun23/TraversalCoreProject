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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public Testimonial getById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tadd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TgetList()
        {
            return _testimonialDal.getList();
        }

        public void Tupdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
