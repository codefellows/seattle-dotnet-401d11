using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Services
{
    public class StudentRepository : IStudent
    {
        private SchoolEnrollmentDbContext _context;

        public StudentRepository(SchoolEnrollmentDbContext context)
        {
            _context = context;
        }
        public async Task<Student> Create(Student student)
        {
            // when i have a student, i want to add them to the database. 
            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            // the student gets 'saved' here, and then associated with an id.
            await _context.SaveChangesAsync();

            return student;

        }

        public async Task Delete(int id)
        {
            Student student = await GetStudent(id);

            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public void MyTestMethod()
        {

        }

        public async Task<Student> GetStudent(int id)
        {
            // look in the db on the student table, where the id is equal to the id that was brought in as an argument
            Student student = await _context.Students.FindAsync(id);
            var enrollments = await _context.Enrollments.Where(x => x.StudentId == id)
                                                   .Include(x => x.Course)
                                                   .ToListAsync();
            student.Enrollments = enrollments;
            return student;
        }

        public async Task<List<Student>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();

            return students;
        }

        public async Task<Student> Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return student;
        }
    }
}
