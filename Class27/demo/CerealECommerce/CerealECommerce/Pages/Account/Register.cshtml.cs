using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using CerealECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CerealECommerce.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<Customer> _usermanager;

        public RegisterModel(UserManager<Customer> userManager)
        {
            _usermanager = userManager;
        }
        // This lets the data from the frontend get sent to the server
        [BindProperty]
        public RegisterViewModel Input { get; set; }
        // Resserved method name for the loading of the page
        public void OnGet()
        {
            // what is going to populate on the page load?
        }

        // another reserved method name for the post of the page
        public void OnPost()
        {
            // capture all the values in our input and create a user and savve them into our db
            // user usermanager to create and save the user.
            
            // when the user "posts back". what happens?
            // does it save to the DB
            // does it make an aPI call
            // does it redirect us?
        }

        public class RegisterViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }



}