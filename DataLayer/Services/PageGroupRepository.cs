using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.ViewModels.PageGroup;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCMSContext db;

        public PageGroupRepository(MyCMSContext db)
        {
            this.db = db;
        }
        public IEnumerable<ShowPageGroup> GetAllGroup()
        {
            return db.PageGroups.Select(p => new ShowPageGroup()
            {
                GroupId = p.GroupId,
                GroupTitle = p.GroupTitle,
                Count = db.Pages.Count(pg => pg.GroupId == p.GroupId)
            });
        }

        public PageGroup GetGroupById(int id)
        {
            return db.PageGroups.Find(id);
        }

        public void AddPageGroup(PageGroup pageGroup)
        {
            db.PageGroups.Add(pageGroup);
            db.SaveChanges();
        }

        public void EditPageGroup(PageGroup pageGroup)
        {
            db.Entry(pageGroup).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteGroup(int id)
        {
            var group = GetGroupById(id);
            db.Entry(group).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
