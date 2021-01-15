using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_no = table.Column<int>(type: "int", nullable: false),
                    vendor_no = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClientAccountTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccountTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClientTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_NIC = table.Column<int>(type: "int", nullable: false),
                    F_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    L_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tele_no = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PackagesTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eackage_no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagesTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentsTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    card_no = table.Column<int>(type: "int", nullable: false),
                    cardholder_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exp_date = table.Column<int>(type: "int", nullable: false),
                    cvc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VendorAccountTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorAccountTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VendorTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tele_no = table.Column<int>(type: "int", nullable: false),
                    company_catogary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTable");

            migrationBuilder.DropTable(
                name: "ClientAccountTable");

            migrationBuilder.DropTable(
                name: "ClientTable");

            migrationBuilder.DropTable(
                name: "PackagesTable");

            migrationBuilder.DropTable(
                name: "PaymentsTable");

            migrationBuilder.DropTable(
                name: "VendorAccountTable");

            migrationBuilder.DropTable(
                name: "VendorTable");
        }
    }
}
