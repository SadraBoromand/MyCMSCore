using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.ViewModels.PageGroup;

namespace DataLayer.Repositories
{
  public  interface IPageGroupRepository
  {
      IEnumerable<ShowPageGroup> GetAllGroup();
      PageGroup GetGroupById(int id);
      void AddPageGroup(PageGroup pageGroup);
      void EditPageGroup(PageGroup pageGroup);
      void DeleteGroup(int id);
  }
}
