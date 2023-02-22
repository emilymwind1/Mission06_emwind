using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_emwind.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_emwind.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext DbContext { get; set; }

        public HomeController(MovieContext someName)
        {
            DbContext = someName;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSubmission() 
        {
            ViewBag.Categories = DbContext.Categories.ToList();

            return View();
         }

        [HttpPost]
        public IActionResult MovieSubmission(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                DbContext.Add(ar);
                DbContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                return View(ar);
            }
        }

        [HttpGet]
        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = DbContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movid)
        {
            ViewBag.Categories = DbContext.Categories.ToList();

            var submission = DbContext.responses.Single(x => x.MovieID == movid);

            return View("MovieSubmission", submission);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse appres)
        {
                DbContext.Update(appres);
                DbContext.SaveChanges();

                return RedirectToAction("MovieList");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
