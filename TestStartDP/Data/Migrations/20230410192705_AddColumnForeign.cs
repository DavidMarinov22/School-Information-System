using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestStartDP.Data.Migrations
{
    public partial class AddColumnForeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPerson",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IdPerson",
                table: "AspNetUsers",
                column: "IdPerson");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IdPerson",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdPerson",
                table: "AspNetUsers");
        }
    }
}
