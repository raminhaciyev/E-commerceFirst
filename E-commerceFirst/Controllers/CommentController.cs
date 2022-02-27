using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerceFirst.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult ClientComment()
        {
            var values = cm.GetAllList();
            return View(values);
        }
    }
}
