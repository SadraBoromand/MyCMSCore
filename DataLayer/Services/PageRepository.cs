using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class PageRepository : IPageRepository
    {
        private MyCMSContext db;

        public PageRepository(MyCMSContext db)
        {
            this.db = db;
        }
        public IEnumerable<Page> GetAllPages()
        {
            return db.Pages
                .OrderByDescending(p => p.PageId)
                .ToList();
        }

        public IEnumerable<Page> GetSliderPages()
        {
            return db.Pages.Where(p => p.ShowInSlider == true).ToList();
        }

        public IEnumerable<Page> ShowPageByGroupPage(int groupPageId)
        {
            return db.Pages.Where(p => p.GroupId == groupPageId);
        }

        public Page GetPageById(int pageId)
        {
            return db.Pages
                .Include(p => p.PageGroup)
                .FirstOrDefault(p => p.PageId == pageId);
        }

        public void AddVisit(int pageId)
        {
            db.Pages.Single(p => p.PageId == pageId).Visit += 1;
            db.SaveChanges();
        }

        public bool InsertPage(Page page)
        {
            try
            {
                db.Pages.Add(page);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeletePage(int pageId)
        {
            var page = GetPageById(pageId);
            DeletePage(page);
        }

        public IEnumerable<Page> GetMoreVisitPage()
        {
            return db.Pages
                .Take(4)
                .OrderByDescending(p => p.Visit);
        }

        public IEnumerable<Page> SearchPage(string search)
        {
            return db.Pages
                .Where(p => p.Title.Contains(search) || p.Tags.Contains(search));
        }
    }
}
