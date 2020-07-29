using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models
{
    public class Transcript
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool Passed { get; set; }
        public Grade Grade { get; set; }

        // Navigation Properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

    public enum Grade
    {
        A = 4,
        B = 3,
        C = 2,
        D = 1,
        F = 0

    }
}
