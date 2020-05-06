using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{

    
    public class SquirrelController : Controller
    {
        private IReviewDAO dao;

        public SquirrelController(IReviewDAO squirrel)
        {
            dao = squirrel;
        }


        // GET: Home
        public ActionResult Index()
        {
            var reviews = dao.GetAllReviews();
            return View(reviews);
        }

        public ActionResult Newreview()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Newreview(Review review)
        {
            dao.SaveReview(review);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
