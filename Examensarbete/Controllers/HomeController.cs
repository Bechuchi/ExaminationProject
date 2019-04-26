using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Examensarbete.Models;
using Examensarbete.Services;
using Examensarbete.ViewModels;
using Examensarbete.Data.Identity;
using Microsoft.Extensions.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Examensarbete.Controllers
{
    public class HomeController : Controller
    {
        //Localization
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ApplicationDbContext _context;

        public HomeController(IStringLocalizer<HomeController> localizer,
                              ApplicationDbContext context)
        {
            _localizer = localizer;
            _context = context;
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            //Key/name är det i ["..."]
            //_localiser som översätter strängar
            ViewData["MyTitle"] = _localizer["The localised title of my app!"];

            //var topics = _context.Topic
            //    .Select(x => new TopicViewModel
            //    {
            //        Id = x.Id,
            //        Name = x.NameContent.LanguageContent.First(l => l.LanguageCode == "fr").Content,
            //        Facts = x.Facts.Select(f => new FactViewModel
            //        {
            //            Id = f.Id,
            //            Header = f.HeaderContent.LanguageContent.First(l => l.LanguageCode == "fr").Content,
            //            Text = f.BodyContent.LanguageContent.First(l => l.LanguageCode == "fr").Content
            //        }).ToList()
            //    }).ToList();

            //var viewModel = new CourseViewModel
            //{
            //    Name = "Programming for dummies",
            //    Content = topics
            //};

            //return View(viewModel);

            return View(new HomeViewModel());
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {

            if (!ModelState.IsValid)

            {

                return View(model);

            }

            ViewData["Result"] = _localizer["Success!"];

            return View(model);

        }

        //Ajax gick med POS
        [HttpPost]
        public IActionResult ShowFact(int id)
        {
            var factDb = _context.Facts.First(x => x.Id == id);
            var viewModel = new FactViewModel
            {
                Id = factDb.Id,
                Header = factDb.HeaderContent.LanguageContent.First(h => h.LanguageCode == "fr").Content,
                Text = factDb.BodyContent.LanguageContent.First(b => b.LanguageCode == "fr").Content
            };

            return PartialView(viewModel);            
        }

        public IActionResult About()
        {
            //CourseViewModel viewModel = new CourseViewModel
            //{
            //    Name = "Programming For Dummies",
            //    Content = new List<TopicViewModel>
            //    {
            //        new TopicViewModel
            //        {
            //            Id = 1,
            //            Name = "Background",
            //        },
            //        new TopicViewModel
            //        {
            //            Id = 2,
            //            Name = "Variables"
            //        },
            //        new TopicViewModel
            //        {
            //            Id = 3,
            //            Name = "Loops",
            //            Facts = new List<FactViewModel>
            //            {
            //                new FactViewModel
            //                {
            //                    Id = 1,
            //                    TopicId = 3,
            //                    Header = "While loop"
            //                },
            //                new FactViewModel
            //                {
            //                    Id = 2,
            //                    TopicId = 3,
            //                    Header = "For loop"
            //                },
            //                new FactViewModel
            //                {
            //                    Id = 3,
            //                    TopicId = 3,
            //                    Header = "Do-While loop"
            //                }
            //            }
            //        },
            //        new TopicViewModel
            //        {
            //            Id = 4,
            //            Name = "Functions"
            //        },
            //        new TopicViewModel
            //        {
            //            Id = 5,
            //            Name = "Design Patterns"
            //        }
            //    }
            //};
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
