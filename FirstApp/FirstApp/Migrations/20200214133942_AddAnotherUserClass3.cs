using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApp.Migrations
{
    public partial class AddAnotherUserClass3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnotherUser",
                columns: table => new
                {
                    Ident = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IsMarried = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotherUser", x => new { x.Ident, x.Name });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotherUser");
        }
    }
}
