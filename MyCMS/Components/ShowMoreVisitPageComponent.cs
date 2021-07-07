using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MyCMS.Components
{
    public class ShowMoreVisitPageComponent:ViewComponent
    {
        private IPageRepository _pageRepository;

        public ShowMoreVisitPageComponent(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Components/ShowMoreVisitPageComponent.cshtml", _pageRepository.GetMoreVisitPage());
        }
    }
}
