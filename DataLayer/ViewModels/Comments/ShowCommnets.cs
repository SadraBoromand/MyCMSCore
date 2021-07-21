using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels.Comments
{
    public class ShowCommnets
    {
        public int  CommentId { get; set; }
        [Display(Name = "عنوان خبر")]
        public string PageTitle { get; set; }

        [Display(Name = "نام")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(150)]
        public string Email { get; set; }

        [Display(Name = "سایت")]
        [MaxLength(150)]
        public string WebSite { get; set; }

        [Display(Name = "نظر")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        [MaxLength(500)]
        public string Comment { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public string CreateDate { get; set; }
    }
}
