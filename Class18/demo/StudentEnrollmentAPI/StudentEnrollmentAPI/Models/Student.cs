using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        //Nav propery
        public List<Enrollments> Enrollments { get; set; }

        // Nav properties can wait. we will add those in a couple of days.
    }
}
