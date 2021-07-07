using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repositories
{
   public interface IPageRepository
   {
       Task<IEnumerable<Page>> GetAllPages();
       IEnumerable<Page> GetSliderPages();
       IEnumerable<Page> ShowPageByGroupPage(int groupPageId);
       Page GetPageById(int pageId);
       void AddVisit(int pageId);
       bool InsertPage(Page page);
       bool UpdatePage(Page page);
       bool DeletePage(Page page);
       void DeletePage(int pageId);

       IEnumerable<Page> GetMoreVisitPage();
   }
}
