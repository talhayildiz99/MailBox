using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailBox.DataAccessLayer.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSent",
                table: "Mails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSent",
                table: "Mails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
