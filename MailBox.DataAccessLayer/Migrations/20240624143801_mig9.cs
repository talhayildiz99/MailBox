using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailBox.DataAccessLayer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Mails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Mails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mails_ReceiverId",
                table: "Mails",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_SenderId",
                table: "Mails",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_AspNetUsers_ReceiverId",
                table: "Mails",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_AspNetUsers_SenderId",
                table: "Mails",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mails_AspNetUsers_ReceiverId",
                table: "Mails");

            migrationBuilder.DropForeignKey(
                name: "FK_Mails_AspNetUsers_SenderId",
                table: "Mails");

            migrationBuilder.DropIndex(
                name: "IX_Mails_ReceiverId",
                table: "Mails");

            migrationBuilder.DropIndex(
                name: "IX_Mails_SenderId",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Mails");
        }
    }
}
