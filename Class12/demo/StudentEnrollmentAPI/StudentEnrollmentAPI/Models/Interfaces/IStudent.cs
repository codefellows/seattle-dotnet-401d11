using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Interfaces
{
    public interface IStudent
    {
        //contain methods and properties that are required for the classes to implement

        // Create
        Task<Student> Create(Student student);

        // Read
        // Get All
        Task<List<Student>> GetStudents();

        // Get individually (by Id)
        Task<Student> GetStudent(int id);

        // Update
        Task<Student> Update(Student student);

        // Delete
        Task Delete(int id);
    }
}
