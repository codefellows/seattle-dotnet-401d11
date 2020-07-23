using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public Technology Technology { get; set; }
        public decimal Price { get; set; }

        // Nav properties

        public List<Enrollments> Enrollments { get; set; }
    }

    public enum Technology
    {
        dotNet = 1,
        java,
        python,
        javascript
    }
}
