using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using CerealECommerce.Models;
using CerealECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CerealECommerce.Controllers
{
    public class ProductController : Controller
    {
        private IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Force cast the data type
            List<Cereal> prods = _product.GetProducts().Cast<Cereal>().ToList();

            ProductsViewModel vm = new ProductsViewModel
            {
                Products = prods,
                Term = ""
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(string term)
        {
            // Force cast the data type
            List<Cereal> prods = _product.GetProducts().Cast<Cereal>().ToList();
            var results = prods.Where(x => x.Name.Contains(term));

            ProductsViewModel vm = new ProductsViewModel
            {
                Products = results.Cast<Cereal>().ToList(),
                Term = term
            };
            return View(vm);
        }
    }
}
