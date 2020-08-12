using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
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
        private SignInManager<Customer> _signInManager;

        public RegisterModel(UserManager<Customer> userManager, SignInManager<Customer> signInManager)
        {
            _usermanager = userManager;
            _signInManager = signInManager;
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
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                // register the user

                Customer customer = new Customer()
                {
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    UserName = Input.Email
                };

                var result = await _usermanager.CreateAsync(customer, Input.Password);
                if (result.Succeeded)
                {


                    Claim claim = new Claim("FullName", $"{Input.FirstName} {Input.LastName}");

                    await _usermanager.AddClaimAsync(customer, claim);

                    await _signInManager.SignInAsync(customer, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }

            }

            return Page();
            // capture all the values in our input and create a user and savve them into our db
            // user usermanager to create and save the user.

            // when the user "posts back". what happens?
            // does it save to the DB
            // does it make an aPI call
            // does it redirect us?
        }

        public class RegisterViewModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Legal First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]

            public string LastName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password")]
            [Display(Name = "Confirm Password")]

            public string ConfirmPassword { get; set; }
        }

    }



}