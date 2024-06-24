using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailBox.DataAccessLayer.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mails_AspNetUsers_AppUserId",
                table: "Mails");

            migrationBuilder.DropIndex(
                name: "IX_Mails_AppUserId",
                table: "Mails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Mails_AppUserId",
                table: "Mails",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_AspNetUsers_AppUserId",
                table: "Mails",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
