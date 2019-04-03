using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Examensarbete.Models;
using Examensarbete.Services;
using Examensarbete.ViewModels.TopicViewModels;
using Examensarbete.ViewModels.CourseViewModels;
using Examensarbete.Data.Identity;

namespace Examensarbete.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExamService _businessService;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context,
                              IExamService businessService)
        {
            _context = context;
            _businessService = businessService;
        }

        public IActionResult Index()
        {
            CourseViewModel viewModel = new CourseViewModel
            {
                Name = "Programming For Dummies",
                Content = new List<TopicViewModel>
                {
                    new TopicViewModel
                    {
                        Id = 1,
                        Name = "Background",
                    },
                    new TopicViewModel
                    {
                        Id = 2,
                        Name = "Variables"
                    },
                    new TopicViewModel
                    {
                        Id = 3,
                        Name = "Loops",
                        Facts = new List<FactViewModel>
                        {
                            new FactViewModel
                            {
                                Id = 1,
                                TopicId = 3,
                                Header = "While loop"
                            },
                            new FactViewModel
                            {
                                Id = 2,
                                TopicId = 3,
                                Header = "For loop"
                            },
                            new FactViewModel
                            {
                                Id = 3,
                                TopicId = 3,
                                Header = "Do-While loop"
                            }
                        }
                    },
                    new TopicViewModel
                    {
                        Id = 4,
                        Name = "Functions"
                    },
                    new TopicViewModel
                    {
                        Id = 5,
                        Name = "Design Patterns"
                    }
                }
            };

            return View(viewModel);
        }

        public void SetDataWindow(int id)
        {
            var facts = new FactViewModel
            {
                Header = "LOOPS",
                Text = "for loop is loooooooooop"
            };

            
        }

        public IActionResult About()
        {
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
