using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class CvcintoCVV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvc",
                table: "PaymentsTable");

            

            migrationBuilder.AlterColumn<string>(
                name: "exp_date",
                table: "PaymentsTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "card_no",
                table: "PaymentsTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "cvv",
                table: "PaymentsTable",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvv",
                table: "PaymentsTable");


            migrationBuilder.AlterColumn<int>(
                name: "exp_date",
                table: "PaymentsTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "card_no",
                table: "PaymentsTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cvc",
                table: "PaymentsTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

     
        }
    }
}
