using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.ViewModels.Comments;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class PageCommentRepository : IPageCommentRepository
    {
        private MyCMSContext db;

        public PageCommentRepository(MyCMSContext db)
        {
            this.db = db;
        }

        public IEnumerable<ShowCommnets> GetAllComments()
        {
            return db.PageComments.Select(c => new ShowCommnets()
            {
                CommentId = c.CommentId,
                PageTitle = db.Pages.Single(p => p.PageId == c.PageId).Title,
                Name = c.Name,
                WebSite = c.WebSite,
                Comment = c.Comment,
                CreateDate = c.CreateDate,
                Email = c.Email
            });
        }

        public IEnumerable<PageComment> getAllCommentsPage(int id)
        {
            return db.PageComments.Where(c => c.PageId == id);
        }

        public void AddComment(PageComment comment)
        {
            db.PageComments.Add(comment);
            db.SaveChanges();
        }

        public void DeleteComment(int commentId)
        {
            var comment = db.PageComments.Find(commentId);
            db.Entry(comment).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
