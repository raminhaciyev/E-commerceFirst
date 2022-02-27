using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerceFirst.Controllers
{
    public class NewsMailController : Controller
    {
        NewsMailManager nm = new NewsMailManager(new EfNewsMailRepository());


        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsMail p)
        {
            p.MailStatus = true;
            nm.AddNewsMail(p);
            return PartialView();
        }
    }
}
