using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class addcarttabwithfriengkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "cartss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestID",
                table: "cartss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableBookingTableID",
                table: "cartss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "cartss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "cartss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "restaurantsRegiRestID",
                table: "cartss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cartss_FoodID",
                table: "cartss",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_cartss_restaurantsRegiRestID",
                table: "cartss",
                column: "restaurantsRegiRestID");

            migrationBuilder.CreateIndex(
                name: "IX_cartss_TableBookingTableID",
                table: "cartss",
                column: "TableBookingTableID");

            migrationBuilder.CreateIndex(
                name: "IX_cartss_UserID",
                table: "cartss",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_cartss_foodss_FoodID",
                table: "cartss",
                column: "FoodID",
                principalTable: "foodss",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cartss_restaurantsRegiiss_restaurantsRegiRestID",
                table: "cartss",
                column: "restaurantsRegiRestID",
                principalTable: "restaurantsRegiiss",
                principalColumn: "RestID");

            migrationBuilder.AddForeignKey(
                name: "FK_cartss_TableBookingss_TableBookingTableID",
                table: "cartss",
                column: "TableBookingTableID",
                principalTable: "TableBookingss",
                principalColumn: "TableID");

            migrationBuilder.AddForeignKey(
                name: "FK_cartss_Userrss_UserID",
                table: "cartss",
                column: "UserID",
                principalTable: "Userrss",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartss_foodss_FoodID",
                table: "cartss");

            migrationBuilder.DropForeignKey(
                name: "FK_cartss_restaurantsRegiiss_restaurantsRegiRestID",
                table: "cartss");

            migrationBuilder.DropForeignKey(
                name: "FK_cartss_TableBookingss_TableBookingTableID",
                table: "cartss");

            migrationBuilder.DropForeignKey(
                name: "FK_cartss_Userrss_UserID",
                table: "cartss");

            migrationBuilder.DropIndex(
                name: "IX_cartss_FoodID",
                table: "cartss");

            migrationBuilder.DropIndex(
                name: "IX_cartss_restaurantsRegiRestID",
                table: "cartss");

            migrationBuilder.DropIndex(
                name: "IX_cartss_TableBookingTableID",
                table: "cartss");

            migrationBuilder.DropIndex(
                name: "IX_cartss_UserID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "RestID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "TableBookingTableID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "TableID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "cartss");

            migrationBuilder.DropColumn(
                name: "restaurantsRegiRestID",
                table: "cartss");
        }
    }
}
