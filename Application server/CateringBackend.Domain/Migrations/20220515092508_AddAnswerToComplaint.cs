using Microsoft.EntityFrameworkCore.Migrations;

namespace CateringBackend.Domain.Migrations
{
    public partial class AddAnswerToComplaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Complaints");
        }
    }
}
