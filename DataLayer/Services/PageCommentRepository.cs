using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;

namespace DataLayer.Services
{
    public class PageCommentRepository : IPageCommentRepository
    {
        private MyCMSContext db;

        public PageCommentRepository(MyCMSContext db)
        {
            this.db = db;
        }

        public IEnumerable<PageComment> getAllComments(int id)
        {
            return db.PageComments.Where(c => c.PageId == id);
        }

        public void AddComment(PageComment comment)
        {
            db.PageComments.Add(comment);
            db.SaveChanges();
        }
    }
}
