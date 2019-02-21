using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc01.Models;
using SalesWebMvc01.Services;

namespace SalesWebMvc01.Controllers
{
    public class SellersController : Controller
    {
        // declarando uma dependencia para o SellerService, sempre terei que coloar a dependência tanto no controller com no service.
        private readonly SellerService _sellerService;

        // criando o construtor no controler para receber os dados 
        public SellersController (SellerService sellerService )
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            // chamada do FindAll()
            var list = _sellerService.FindAll();
            return View(list);
        }

        // Criando um Nova ação
        public IActionResult Create()
        {
            return View();
        }

        // Informando que a ação não de GET e sim de POST
        [HttpPost] // anotacion POST
        [ValidateAntiForgeryToken] // Anotacion  Impdede ataques SRFS que se aproveitar da sessanão de autenticaão para fazer coisas indesejadas.
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);

            return RedirectToAction(nameof(Index));

        }


    }
}