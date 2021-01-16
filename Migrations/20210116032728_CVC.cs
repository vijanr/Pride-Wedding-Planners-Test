using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class CVC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvv",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "cvc",
                table: "PaymentsTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvc",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "cvv",
                table: "PaymentsTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
