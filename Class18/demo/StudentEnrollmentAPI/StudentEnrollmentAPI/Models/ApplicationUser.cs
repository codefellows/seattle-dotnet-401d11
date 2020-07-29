using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string Principal = "Principal";
        public const string Advisor = "Advisor";
        public const string Teacher = "Teacher";
        public const string Student = "Student";
    }
}
