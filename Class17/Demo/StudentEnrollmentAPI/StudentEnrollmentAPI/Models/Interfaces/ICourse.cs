using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Interfaces
{
    public interface ICourse
    {
        //contain methods and properties that are required for the classes to implement

        // Create
        Task<Course> Create(Course student);

        // Read
        // Get All
        Task<List<Course>> GetCourses();

        // Get individually (by Id)
        Task<Course> GetCourse(int id);

        // Update
        Task<Course> Update(Course student);

        // Delete
        Task Delete(int id);

        Task AddStudent(int studentId, int courseId);

        /// <summary>
        /// Removes a specified student from a specific course
        /// </summary>
        /// <param name="courseId">unique identifier of the course</param>
        /// <param name="studentId">unique identifier of the student</param>
        /// <returns>Task of completion</returns>
        Task RemoveStudentFromCourse(int courseId, int studentId);
    }
}
