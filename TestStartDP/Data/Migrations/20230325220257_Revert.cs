using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestStartDP.Data.Migrations
{
    public partial class Revert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                           name: "FileUpload");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
