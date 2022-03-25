﻿using Chart_in_Core.Models;
using Chart_in_Core.Models.ChartModels;
using Chart_in_Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService _service;

        public HomeController(ILogger<HomeController> logger,IService service)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpGet]
        //public IActionResult Lookup()
        //{
        //    return View(new SellerProductsViewModel());
        //}

        [HttpGet]
        public async Task<IActionResult> Lookup(SellerProductsViewModel model, string CodMelli,int? ddl_sourceId, string ProductId)
        {
            if (ddl_sourceId == null)
            {
                ViewData["vm.Select"] = new SelectList(ddl_Source.Select, "Value", "Text");
            }
            else
            {
                ViewData["vm.Select"] = new SelectList(ddl_Source.Select, "Value", "Text", ddl_sourceId);
            }

            if (CodMelli!=null)
            {
                var lstModel = new List<SimpleReportViewModel>();
                List<SellerProductsDto> lst_prds= await _service.lookup(CodMelli);

                foreach (var item in lst_prds)
                {
                    lstModel.Add(new SimpleReportViewModel
                    {
                        DimensionOne = item.Name,
                        Quantity = item.inventory
                    });
                }
                model = new SellerProductsViewModel
                {
                    productsDtos = lst_prds,
                    ddl_sourceId = ddl_Source.Id,
                    SimpleReports= lstModel,
                    //CodMelli= CodMelli
                };
                
            }
            if(ProductId != null)
            {
                model.productDetailsDtos = _service.GetDetails(ProductId);
            }
           
            return  View(model);
        }

        [HttpGet]
        public IActionResult Details(SellerProductsViewModel model,string id)
        {
             model.productDetailsDtos= _service.GetDetails(id);
            return View(model);
        }

       

         Ddl_Source ddl_Source = new Ddl_Source()
        {
            Select = new List<SelectListItem>
            {
                new SelectListItem {Text = "حقیقی", Value = "1"},
                new SelectListItem {Text = "حقوقی", Value = "2"},
                new SelectListItem {Text = "ارزش افزوده", Value = "3"},
            }
        };
    }
}