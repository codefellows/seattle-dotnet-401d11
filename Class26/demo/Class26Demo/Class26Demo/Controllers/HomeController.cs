using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class26Demo.Models;
using Class26Demo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Class26Demo.Controllers
{
    public class HomeController : Controller
    {
        // Model Binding allowed us to send name as a  query paramater into the method/action
        //public string Index(string name, int age)
        //{
        //    return $"{name} is {age} years old";
        //}

        public IActionResult Index()
        {
            Post post = new Post()
            {
                Title = "alice in wonderland",
                Description = "I give myself very good advice, but i very seldom follow it."
            };

            Blog blog = new Blog
            {
                AuthorName = "Lewis Carol",
                NumberPostsPerWeek = 100
            };

            BlogPostsVM vm = new BlogPostsVM()
            {
                Post = post,
                Blog = blog
            };

            // cannot send blog since it is not defined in the view.
            return View(vm);
        }
    }
}
