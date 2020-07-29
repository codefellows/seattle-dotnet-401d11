using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollmentAPI.Migrations
{
    public partial class addedStudentSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1970, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Shepard" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate", "Austin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
