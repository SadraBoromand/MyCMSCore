using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class PageGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }


        //navigation Property
        public virtual List<Page> Pages { get; set; }
    }
}
