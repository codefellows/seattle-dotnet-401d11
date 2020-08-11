using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Services
{
    public class CourseRepository : ICourse
    {
        private SchoolEnrollmentDbContext _context;

        public CourseRepository(SchoolEnrollmentDbContext context)
        {
            _context = context;
        }
        public async Task<Course> Create(Course course)
        {
            _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            await _context.SaveChangesAsync();

            return course;
        }

        public async Task Delete(int id)
        {
            var course = await GetCourse(id);
            _context.Entry(course).State = EntityState.Deleted;
        }

        public async Task<List<Course>> GetCourses()
        {
            var courses = await _context.Courses.ToListAsync();
            return courses;
        }

        public async Task<Course> GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);

            // include all of the enrollments that the student has
            var enrollments = await _context.Enrollments.Where(x => x.CourseId == id)
                                                        .Include(x => x.Student)
                                                        .ToListAsync();
            course.Enrollments = enrollments;
            return course;
        }

        public async Task<Course> Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return course;
        }

        // Add a course and a student together

        // In teh RoomRepository
        // add a new method named "AddAmenity"
        // 
        public async Task AddStudent(int studentId, int courseId)
        {
            Enrollments enrollment = new Enrollments()
            {
                CourseId = courseId,
                StudentId = studentId
            };

            _context.Entry(enrollment).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes a specified student from a specific course
        /// </summary>
        /// <param name="courseId">unique identifier of the course</param>
        /// <param name="studentId">unique identifier of the student</param>
        /// <returns>Task of completion</returns>
        public async Task RemoveStudentFromCourse(int courseId, int studentId)
        {
            // look in the enrollments table for the entry that matches the courseid and the studentid
            var result = await _context.Enrollments.FirstOrDefaultAsync(x => x.CourseId == courseId && x.StudentId == studentId);
            _context.Entry(result).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
