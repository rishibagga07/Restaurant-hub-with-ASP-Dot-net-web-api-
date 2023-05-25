using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class CustomersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerOrderID",
                table: "Paymentss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "customerOrders",
                columns: table => new
                {
                    CustomerOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerOrderProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    CustomerOrderPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerOrderTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerOrderGrandTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableID = table.Column<int>(type: "int", nullable: false),
                    TableBookingTableID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerOrders", x => x.CustomerOrderID);
                    table.ForeignKey(
                        name: "FK_customerOrders_TableBookingss_TableBookingTableID",
                        column: x => x.TableBookingTableID,
                        principalTable: "TableBookingss",
                        principalColumn: "TableID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paymentss_CustomerOrderID",
                table: "Paymentss",
                column: "CustomerOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_customerOrders_TableBookingTableID",
                table: "customerOrders",
                column: "TableBookingTableID");

            migrationBuilder.AddForeignKey(
                name: "FK_Paymentss_customerOrders_CustomerOrderID",
                table: "Paymentss",
                column: "CustomerOrderID",
                principalTable: "customerOrders",
                principalColumn: "CustomerOrderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paymentss_customerOrders_CustomerOrderID",
                table: "Paymentss");

            migrationBuilder.DropTable(
                name: "customerOrders");

            migrationBuilder.DropIndex(
                name: "IX_Paymentss_CustomerOrderID",
                table: "Paymentss");

            migrationBuilder.DropColumn(
                name: "CustomerOrderID",
                table: "Paymentss");
        }
    }
}
