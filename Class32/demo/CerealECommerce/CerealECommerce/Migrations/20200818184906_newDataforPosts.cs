using Microsoft.EntityFrameworkCore.Migrations;

namespace CerealECommerce.Migrations
{
    public partial class newDataforPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "Hello beautiful wonderful world!", "Hello World" },
                    { 2, "Oh, you can’t help that,” said the Cat: “we’re all mad here. I’m mad. You’re mad.” “How do you know I’m mad?” said Alice. “You must be,” said the Cat, or you wouldn’t have come here.", "We're All Mad" },
                    { 3, "It’s no use going back to yesterday,because I was a different person then.", "Yesterday, Yesterday" },
                    { 4, "She generally gave herself very good advice (though she very seldom followed it)", "Good advice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
