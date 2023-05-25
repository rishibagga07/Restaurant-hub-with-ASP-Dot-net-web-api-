using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class modifycustomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableID",
                table: "customerOrders");

            migrationBuilder.RenameColumn(
                name: "CustomerOrderGrandTotal",
                table: "customerOrders",
                newName: "CustomerOrderFoodImage");

            migrationBuilder.AddColumn<int>(
                name: "RestID",
                table: "customerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestID",
                table: "customerOrders");

            migrationBuilder.RenameColumn(
                name: "CustomerOrderFoodImage",
                table: "customerOrders",
                newName: "CustomerOrderGrandTotal");

            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "customerOrders",
                type: "int",
                nullable: true);
        }
    }
}
