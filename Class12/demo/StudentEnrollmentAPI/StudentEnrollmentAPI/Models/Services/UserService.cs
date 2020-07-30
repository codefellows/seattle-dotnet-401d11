using Microsoft.AspNetCore.Identity;
using SQLitePCL;
using StudentEnrollmentAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Services
{
    public class UserService
    {
        private SchoolEnrollmentDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SchoolEnrollmentDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public bool ValidateInstructor(List<Claim> claims, int courseId)
        {
            // get the details about the instructor

            // confirm that the user has access to that course
            //var nameClaim = claims.FirstOrDefault(x => x.Type == "FirstName").Value;

            //if(nameClaim == "Amanda")
            //{
            //    // do something cool
            //}

            return true;


        }
    }
}
