using Microsoft.EntityFrameworkCore.Storage;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Models.Interfaces;
using StudentEnrollmentAPI.Models.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class StudentServiceTest : DatabaseTestBase
    {
        private IStudent BuildRepository()
        {
            return new StudentRepository(_db);
        }

        [Fact]
        public async Task CanSaveAndGet()
        {
            // Arrange
            var student = new Student
            {
                FirstName = "Josie",
                LastName = "Cat",
                Birthdate = DateTime.Now
            };

            var repository = BuildRepository();

            // Act
            var saved = await repository.Create(student);

            // Assert
            Assert.NotNull(saved);
            Assert.NotEqual(0, student.Id);
            Assert.Equal(saved.Id, student.Id);
            Assert.Equal(student.FirstName, saved.FirstName);
        }
    }
}
