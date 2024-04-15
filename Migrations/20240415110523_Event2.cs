using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTTokenAPI.Migrations
{
    public partial class Event2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Event");
        }
    }
}
