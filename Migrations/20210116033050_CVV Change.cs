using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class CVVChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvc",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "PaymentsTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "cvc",
                table: "PaymentsTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
