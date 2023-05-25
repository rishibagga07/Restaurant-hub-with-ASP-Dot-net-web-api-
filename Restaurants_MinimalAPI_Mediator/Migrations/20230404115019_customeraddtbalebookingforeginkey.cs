using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class customeraddtbalebookingforeginkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableBookingTableID",
                table: "customerOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "customerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_customerOrders_TableBookingTableID",
                table: "customerOrders",
                column: "TableBookingTableID");

            migrationBuilder.AddForeignKey(
                name: "FK_customerOrders_TableBookingss_TableBookingTableID",
                table: "customerOrders",
                column: "TableBookingTableID",
                principalTable: "TableBookingss",
                principalColumn: "TableID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerOrders_TableBookingss_TableBookingTableID",
                table: "customerOrders");

            migrationBuilder.DropIndex(
                name: "IX_customerOrders_TableBookingTableID",
                table: "customerOrders");

            migrationBuilder.DropColumn(
                name: "TableBookingTableID",
                table: "customerOrders");

            migrationBuilder.DropColumn(
                name: "TableID",
                table: "customerOrders");
        }
    }
}
