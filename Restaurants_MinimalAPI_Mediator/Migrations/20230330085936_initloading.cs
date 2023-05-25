using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    public partial class initloading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "approvallss",
                columns: table => new
                {
                    ApprovalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_approvallss", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "cartss",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartQauntity = table.Column<int>(type: "int", nullable: false),
                    CartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CartAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartss", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "Countrieess",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrieess", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "foodCategoriess",
                columns: table => new
                {
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodCategoriess", x => x.FoodCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Paymentss",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentss", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Roleess",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roleess", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "TableBookingss",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBookingss", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "Stateess",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stateess", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_Stateess_Countrieess_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countrieess",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "foodss",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodPrice = table.Column<int>(type: "int", nullable: false),
                    FoodImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodss", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_foodss_foodCategoriess_FoodCategoryID",
                        column: x => x.FoodCategoryID,
                        principalTable: "foodCategoriess",
                        principalColumn: "FoodCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citieess",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citieess", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Citieess_Stateess_StateID",
                        column: x => x.StateID,
                        principalTable: "Stateess",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "restaurantsRegiiss",
                columns: table => new
                {
                    RestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    FeedBack = table.Column<int>(type: "int", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    ApprovalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantsRegiiss", x => x.RestID);
                    table.ForeignKey(
                        name: "FK_restaurantsRegiiss_approvallss_ApprovalID",
                        column: x => x.ApprovalID,
                        principalTable: "approvallss",
                        principalColumn: "ApprovalID");
                    table.ForeignKey(
                        name: "FK_restaurantsRegiiss_Citieess_CityID",
                        column: x => x.CityID,
                        principalTable: "Citieess",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_restaurantsRegiiss_Roleess_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roleess",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Userrss",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ApprovalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userrss", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Userrss_approvallss_ApprovalID",
                        column: x => x.ApprovalID,
                        principalTable: "approvallss",
                        principalColumn: "ApprovalID");
                    table.ForeignKey(
                        name: "FK_Userrss_Citieess_CityID",
                        column: x => x.CityID,
                        principalTable: "Citieess",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Userrss_Roleess_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roleess",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citieess_StateID",
                table: "Citieess",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_foodss_FoodCategoryID",
                table: "foodss",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_restaurantsRegiiss_ApprovalID",
                table: "restaurantsRegiiss",
                column: "ApprovalID");

            migrationBuilder.CreateIndex(
                name: "IX_restaurantsRegiiss_CityID",
                table: "restaurantsRegiiss",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_restaurantsRegiiss_RoleID",
                table: "restaurantsRegiiss",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Stateess_CountryID",
                table: "Stateess",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Userrss_ApprovalID",
                table: "Userrss",
                column: "ApprovalID");

            migrationBuilder.CreateIndex(
                name: "IX_Userrss_CityID",
                table: "Userrss",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Userrss_RoleID",
                table: "Userrss",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartss");

            migrationBuilder.DropTable(
                name: "foodss");

            migrationBuilder.DropTable(
                name: "Paymentss");

            migrationBuilder.DropTable(
                name: "restaurantsRegiiss");

            migrationBuilder.DropTable(
                name: "TableBookingss");

            migrationBuilder.DropTable(
                name: "Userrss");

            migrationBuilder.DropTable(
                name: "foodCategoriess");

            migrationBuilder.DropTable(
                name: "approvallss");

            migrationBuilder.DropTable(
                name: "Citieess");

            migrationBuilder.DropTable(
                name: "Roleess");

            migrationBuilder.DropTable(
                name: "Stateess");

            migrationBuilder.DropTable(
                name: "Countrieess");
        }
    }
}
