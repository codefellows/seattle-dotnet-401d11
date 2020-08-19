using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CerealECommerce.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CerealECommerce.Pages.Dashboard
{
    public class PictureModel : PageModel
    {
        private IImage _image;

        public PictureModel(IImage image)
        {
            _image = image;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
