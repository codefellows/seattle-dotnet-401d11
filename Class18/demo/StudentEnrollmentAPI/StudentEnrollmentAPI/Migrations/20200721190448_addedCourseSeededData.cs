using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollmentAPI.Migrations
{
    public partial class addedCourseSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "Price", "Technology" },
                values: new object[] { 1, "seattle-dotnet-401d11", 100m, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "Price", "Technology" },
                values: new object[] { 2, "seattle-201d100", 50m, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
