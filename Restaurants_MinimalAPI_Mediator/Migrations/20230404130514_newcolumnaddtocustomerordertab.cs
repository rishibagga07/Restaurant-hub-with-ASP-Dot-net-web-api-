using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class newcolumnaddtocustomerordertab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "customerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "customerOrders");
        }
    }
}
