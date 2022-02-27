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
    public class NewsMailManager: INewsMailService
    {
        INewsMailDal _newsMailDal;

        public NewsMailManager(INewsMailDal newsMailDal)
        {
            _newsMailDal = newsMailDal;
        }

        public void AddNewsMail(NewsMail newsMail)
        {
            _newsMailDal.Insert(newsMail);
        }
    }
}
