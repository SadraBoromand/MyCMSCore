using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.ViewModels.Comments;
using Newtonsoft.Json;

namespace MyCMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentsController : Controller
    {
        private IPageCommentRepository _commentRepository;

        public CommentsController(IPageCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllComments()
        {
            return Json(_commentRepository.GetAllComments());
        }

        public JsonResult Delete(int id)
        {
            _commentRepository.DeleteComment(id);
            return Json(_commentRepository.GetAllComments());
        }
    }
}
