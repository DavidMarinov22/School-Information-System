using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestStartDP.Data.Migrations
{
    public partial class NewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_IdPerson",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IdPerson",
                table: "AspNetUsers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonIdPerson",
                table: "AspNetUsers",
                column: "PersonIdPerson",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonIdPerson",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonIdPerson",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonIdPerson",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IdPerson",
                table: "AspNetUsers",
                column: "IdPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_IdPerson",
                table: "AspNetUsers",
                column: "IdPerson",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
