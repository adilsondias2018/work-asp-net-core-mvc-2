using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc01.Services;

namespace SalesWebMvc01.Controllers
{
    public class SellersController : Controller
    {
        // declarando uma dependencia para o SellerService

        private readonly SellerService _sellerService;

        public SellersController (SellerService sellerService )
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {

            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}