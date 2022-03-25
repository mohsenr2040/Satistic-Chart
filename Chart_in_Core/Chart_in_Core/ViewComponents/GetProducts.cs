using Chart_in_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.ViewComponents
{
    public class GetProducts:ViewComponent
    {
        private readonly IService _service;
        public GetProducts(IService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            return View(viewName: "GetProducts");
        }
    }
}
