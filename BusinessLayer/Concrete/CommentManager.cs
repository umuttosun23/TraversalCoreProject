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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Tadd(Comment t)
        {
            _commentDal.insert(t);
        }

        public void Tdelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TgetList()
        {
            throw new NotImplementedException();
        }
        public List<Comment> TgetDestinationById(int id)
        {
            return _commentDal.getListByFilter(x=>x.DestinationID==id);
        }

        public void Tupdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
