using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MyCMS.Views.Components
{
    public class PageGroupComponent:ViewComponent
    {
        private IPageGroupRepository _pageGroupRepository;

        public PageGroupComponent(IPageGroupRepository pageGroupRepository)
        {
            _pageGroupRepository = pageGroupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Components/PageGroupComponent.cshtml", _pageGroupRepository.GetAllGroup());
        }
    }
}
