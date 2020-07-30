using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public abstract class DatabaseTestBase : IDisposable
    {
        private readonly SqliteConnection _connection;
        protected readonly SchoolEnrollmentDbContext _db;

        public DatabaseTestBase()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            _db = new SchoolEnrollmentDbContext(
                new DbContextOptionsBuilder<SchoolEnrollmentDbContext>()
                .UseSqlite(_connection)
                .Options);

            _db.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _db?.Dispose();
            _connection?.Dispose();
        }
    }
}
