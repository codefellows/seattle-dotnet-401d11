using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CerealECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CerealECommerce.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private SignInManager<Customer> _signInManager;

        public LogoutModel(SignInManager<Customer> signIn)
        {
            _signInManager = signIn;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}