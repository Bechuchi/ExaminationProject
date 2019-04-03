using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Examensarbete.Models;
using Examensarbete.Services;
using Examensarbete.ViewModels.TopicViewModels;

namespace Examensarbete.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExamService _businessService;

        public HomeController(IExamService businessService)
        {
            _businessService = businessService;
        }

        public IActionResult Index()
        {
            TopicViewModel loops = new TopicViewModel
            {
                Id = 3,
                Name = "Loops",
                Areas = new List<string>
                {
                    "Fact",
                    "Exercices",
                    "Exams"
                }
            };

            TopicViewModel functions = new TopicViewModel
            {
                Id = 4,
                Name = "Functions",
                Areas = new List<string>
                {
                    "Fact",
                    "Exercices",
                    "Exams"
                }
            };

            List<TopicViewModel> viewModel = new List<TopicViewModel>();
            viewModel.Add(loops);
            viewModel.Add(functions);

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            TopicViewModel loops = new TopicViewModel
            {
                Id = 3,
                Name = "Loops",
                Areas = new List<string>
                {
                    "Fact",
                    "Exercices",
                    "Exams"
                }
            };

            TopicViewModel functions = new TopicViewModel
            {
                Id = 4,
                Name = "Functions",
                Areas = new List<string>
                {
                    "Fact",
                    "Exercices",
                    "Exams"
                }
            };

            List<TopicViewModel> viewModel = new List<TopicViewModel>();
            viewModel.Add(loops);
            viewModel.Add(functions);

            return View(viewModel);
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
