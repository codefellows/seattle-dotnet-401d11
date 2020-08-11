using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models
{
    public class Enrollments
    {
        // our composite key is both keys together combined
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Navigation property
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
