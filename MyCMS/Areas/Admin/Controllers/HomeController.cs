using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.ViewModels.Page;
using Microsoft.AspNetCore.Authorization;

namespace MyCMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private IPageRepository _pageRepository;
        private IPageGroupRepository _pageGroupRepository;

        public HomeController(IPageRepository pageRepository, IPageGroupRepository pageGroupRepository)
        {
            _pageRepository = pageRepository;
            _pageGroupRepository = pageGroupRepository;
        }

        public IActionResult Index()
        {
            return View(_pageRepository.GetAllPages());
        }

        #region Page CRUD

        public IActionResult AddPage()
        {
            return View(new AddEditPage()
            {
                Title = "",
                ShortDescription = "",
                Text = "",
                PageId = 0,
                PageGroups = _pageGroupRepository.GetAllGroup().ToList()
            });
        }

        [HttpPost]
        public IActionResult AddPage(AddEditPage page)
        {
            if (!ModelState.IsValid)
            {
                return View(page);
            }

            string imageName = "Default.png";
            if (page.NewImage != null)
            {
                imageName = Path.Combine(Guid.NewGuid().ToString() + Path.GetExtension(page.NewImage.FileName));
            }
            _pageRepository.InsertPage(new Page()
            {
                Title = page.Title,
                Text = page.Text,
                Tags = page.Tags,
                CreateDate = DateTime.Now,
                Image = imageName,
                ShowInSlider = page.ShowInSlider,
                ShortDescription = page.ShortDescription,
                GroupId = page.GroupId
            });

            if (page.NewImage != null)
            {
                imageName = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "images",
                    imageName);
                using (FileStream stream = new FileStream(imageName, FileMode.Create))
                {
                    page.NewImage.CopyTo(stream);
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditPage(int pageId)
        {
            var page = _pageRepository.GetPageById(pageId);
            return View(new AddEditPage()
            {
                PageId = page.PageId,
                Image = page.Image,
                Title = page.Title,
                GroupId = page.GroupId,
                PageGroups = _pageGroupRepository.GetAllGroup().ToList(),
                ShortDescription = page.ShortDescription,
                ShowInSlider = page.ShowInSlider,
                Text = page.Text,
                Tags = page.Tags
            });
        }

        [HttpPost]
        public IActionResult EditPage(AddEditPage page)
        {
            if (!ModelState.IsValid)
            {
                return View(page);
            }

            string imageName = page.Image;
            if (page.NewImage != null)
            {
                imageName = Path.Combine(Guid.NewGuid().ToString() + Path.GetExtension(page.NewImage.FileName));
            }

            _pageRepository.UpdatePage(new Page()
            {
                PageId = page.PageId,
                Image = imageName,
                Title = page.Title,
                GroupId = page.GroupId,
                ShortDescription = page.ShortDescription,
                ShowInSlider = page.ShowInSlider,
                Text = page.Text,
                Tags = page.Tags,
                CreateDate = DateTime.Now
            });

            if (page.NewImage != null)
            {
                imageName = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "images",
                    imageName);
                using (FileStream stream = new FileStream(imageName, FileMode.Create))
                {
                    page.NewImage.CopyTo(stream);
                }
            }

            return RedirectToAction("Index");
        }


        public IActionResult DeletePage(int pageId)
        {
            _pageRepository.DeletePage(pageId);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
