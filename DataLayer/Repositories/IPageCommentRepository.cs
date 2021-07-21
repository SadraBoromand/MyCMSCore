using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.ViewModels.Comments;

namespace DataLayer.Repositories
{
    public interface IPageCommentRepository
    {
        IEnumerable<ShowCommnets> GetAllComments();
        IEnumerable<PageComment> getAllCommentsPage(int id);
        void AddComment(PageComment comment);
        void DeleteComment(int commentId);

    }
}
