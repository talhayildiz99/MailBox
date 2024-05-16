using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailBox.DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Mails",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mails_AspNetUsers_AppUserId",
                table: "Mails");

            migrationBuilder.DropIndex(
                name: "IX_Mails_AppUserId",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Mails");
        }
    }
}
