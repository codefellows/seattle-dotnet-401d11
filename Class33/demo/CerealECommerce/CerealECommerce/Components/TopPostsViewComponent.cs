using CerealECommerce.Data;
using CerealECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Components
{
    [ViewComponent]
    public class TopPostsViewComponent : ViewComponent
    {
        private ProductsDbContext _context;

        public TopPostsViewComponent(ProductsDbContext context)
        {
            _context = context;
        }
        // make actions

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            // do some logic to pull from the DB, the posts
            var posts = await _context.Posts.OrderByDescending(x => x.ID).Take(number).ToListAsync();
            
            return View(posts);
        }
    }
}
