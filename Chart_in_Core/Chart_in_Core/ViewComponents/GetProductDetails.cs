using Chart_in_Core.Models;
using Chart_in_Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.ViewComponents
{
    public class GetProductDetails:ViewComponent
    {
        private readonly IService _service;
        public GetProductDetails(IService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            return View(viewName: "GetProductDetails");
        }

    }
}
