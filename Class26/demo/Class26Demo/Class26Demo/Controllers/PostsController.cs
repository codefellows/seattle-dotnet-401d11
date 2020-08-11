using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Class26Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class26Demo.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string title, string description)
        {
            Post post = new Post()
            {
                Title = title,
                Description = description
            };

            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            return RedirectToAction("Details", new { post.Title, post.Description });
        }


    }
}
