using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;

namespace MyCMS.Controllers
{
    public class CommentController : Controller
    {
        private IPageCommentRepository _commentRepository;

        public CommentController(IPageCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public JsonResult GetAllComments(int id)
        {
            return Json(_commentRepository.getAllComments(id));
        }

        public JsonResult AddComment(string pageId, string name,
            string email, string webSite, string comment)
        {
            var commentAdd = new PageComment()
            {
                PageId = int.Parse(pageId),
                CreateDate = DateTime.Now,
                Email = email,
                Name = name,
                WebSite = webSite,
                Comment = comment
            };

            _commentRepository.AddComment(commentAdd);

            return Json(commentAdd);
        }
    }
}
