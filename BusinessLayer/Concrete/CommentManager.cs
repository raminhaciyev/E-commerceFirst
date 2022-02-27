using BusinessLayer.Abstract;
using DataAccessLayer.Abstact;
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

        public void AddComment(Comment category)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment category)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllList()
        {
            return _commentDal.GetAllList();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentListWithProduct()
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment category)
        {
            throw new NotImplementedException();
        }
    }
}
