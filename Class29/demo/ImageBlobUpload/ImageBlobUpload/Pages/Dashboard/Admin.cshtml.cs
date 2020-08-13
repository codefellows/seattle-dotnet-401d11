using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImageBlobUpload.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageBlobUpload.Pages.Dashboard
{
    public class AdminModel : PageModel
    {
        private IImage _image;

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public AdminModel(IImage image)
        {
            _image = image;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
          string ext = Path.GetExtension(Image.FileName);
            // Goal: send the uploaded image to Blob

            // convert Image into a stream

            if (Image != null)
            {
                using (var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    var bytes = stream.ToArray();
                    await _image.UploadFile("pictures", $"{Name}{ext}", bytes, Image.ContentType);     
                }
            }
        }
    }
}