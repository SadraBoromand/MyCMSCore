using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCMS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.Services;

namespace MyCMS.Controllers
{
    public class HomeController : Controller
    {
        private IPageRepository _pageRepository;

        public HomeController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public IActionResult Index()
        {
            return View( _pageRepository.GetAllPages());
        }

        public IActionResult Search(string search)
        {
            ViewData["search"] = search;
            return View(_pageRepository.SearchPage(search));
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
