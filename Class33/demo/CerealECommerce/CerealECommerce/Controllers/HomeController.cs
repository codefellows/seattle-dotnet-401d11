using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CerealECommerce.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CerealECommerce.Controllers
{
    public class HomeController : Controller
    {
        private IPayment _payment;

        public HomeController(IPayment payment)
        {
            _payment = payment;
        }
        public IActionResult Index()
        {
            _payment.Run();
            return View();
        }
    }
}
