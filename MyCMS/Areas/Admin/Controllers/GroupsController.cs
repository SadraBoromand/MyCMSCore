using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.ViewModels.PageGroup;

namespace MyCMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GroupsController : Controller
    {
        private IPageGroupRepository _pageGroupRepository;

        public GroupsController(IPageGroupRepository pageGroupRepository)
        {
            _pageGroupRepository = pageGroupRepository;
        }

        public IActionResult Index()
        {
            return View(_pageGroupRepository.GetAllGroup());
        }

        public JsonResult GetAllGroup()
        {
            return Json(_pageGroupRepository.GetAllGroup());
        }

        public IActionResult AddGroup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGroup(PageGroup group)
        {
            if (!ModelState.IsValid)
            {
                return View(group);
            }

            _pageGroupRepository.AddPageGroup(group);
            return Redirect("/Admin/Groups");
        }

        public IActionResult EditGroup(int groupId)
        {
            return View(_pageGroupRepository.GetGroupById(groupId));
        }

        [HttpPost]
        public IActionResult EditGroup(PageGroup group)
        {
            if (!ModelState.IsValid)
            {
                return View(group);
            }

            _pageGroupRepository.EditPageGroup(group);

            return Redirect("/Admin/Groups");
        }

        public IActionResult DeleteGroup(int groupId)
        {
            _pageGroupRepository.DeleteGroup(groupId);
            return Redirect("/Admin/Groups");
        }
    }
}
