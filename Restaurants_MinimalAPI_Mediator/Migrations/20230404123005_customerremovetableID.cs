using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class customerremovetableID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "customerOrders",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableID",
                table: "customerOrders");
        }
    }
}
