using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;

namespace MyCMS.Controllers
{
    public class PagesController : Controller
    {
        private IPageRepository _pageRepository;

        public PagesController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        //[ViewData]
        //public string Title { get; set; }
        //[Route("/{title}/{pageId}")]
        public IActionResult ShowPage(string title, int pageId)
        {
            //Title = title;
            _pageRepository.AddVisit(pageId);
            var page = _pageRepository.GetPageById(pageId);
            return View("ShowPage", page);
        }

        [Route("ShowPageByGroupPage/{groupPageId}/{groupTitle}")]
        public IActionResult ShowPageByGroupPage(int groupPageId, string groupTitle)
        {
            ViewData["groupTitle"] = groupTitle;

            return View(_pageRepository.ShowPageByGroupPage(groupPageId));
        }

    }
}
