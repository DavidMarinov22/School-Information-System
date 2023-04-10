using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestStartDP.Data.Migrations
{
    public partial class DeleteColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonIdPerson",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonIdPerson",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonIdPerson",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonIdPerson",
                table: "AspNetUsers",
                column: "PersonIdPerson");

        }
    }
}
