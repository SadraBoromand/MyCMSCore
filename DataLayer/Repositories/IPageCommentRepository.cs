using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repositories
{
    public interface IPageCommentRepository
    {
        IEnumerable<PageComment> getAllComments(int id);
        void AddComment(PageComment comment);
    }
}
