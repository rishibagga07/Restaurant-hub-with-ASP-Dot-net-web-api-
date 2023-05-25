﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurants_MinimalAPI_Mediator.Data;

#nullable disable

namespace Restaurants_MinimalAPI_Mediator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230404115208_customerremovetableky")]
    partial class customerremovetableky
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Approval", b =>
                {
                    b.Property<int>("ApprovalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApprovalID"), 1L, 1);

                    b.Property<string>("ApprovalType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApprovalID");

                    b.ToTable("approvallss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<double>("CartAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("CartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CartQauntity")
                        .HasColumnType("int");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("RestID")
                        .HasColumnType("int");

                    b.Property<int?>("TableBookingTableID")
                        .HasColumnType("int");

                    b.Property<int>("TableID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("restaurantsRegiRestID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("FoodID");

                    b.HasIndex("TableBookingTableID");

                    b.HasIndex("UserID");

                    b.HasIndex("restaurantsRegiRestID");

                    b.ToTable("cartss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"), 1L, 1);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateID")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("Citieess");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"), 1L, 1);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countrieess");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.CustomerOrder", b =>
                {
                    b.Property<int>("CustomerOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerOrderID"), 1L, 1);

                    b.Property<string>("CustomerOrderGrandTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerOrderPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerOrderProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerOrderQuantity")
                        .HasColumnType("int");

                    b.Property<string>("CustomerOrderTotal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerOrderID");

                    b.ToTable("customerOrders");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<int>("FoodCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("FoodImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodPrice")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.HasIndex("FoodCategoryID");

                    b.ToTable("foodss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.FoodCategory", b =>
                {
                    b.Property<int>("FoodCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodCategoryID"), 1L, 1);

                    b.Property<string>("FoodCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodCategoryID");

                    b.ToTable("foodCategoriess");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"), 1L, 1);

                    b.Property<int>("CustomerOrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.HasKey("PaymentID");

                    b.HasIndex("CustomerOrderID");

                    b.ToTable("Paymentss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.RestaurantsRegi", b =>
                {
                    b.Property<int>("RestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestID"), 1L, 1);

                    b.Property<int?>("ApprovalID")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int?>("FeedBack")
                        .HasColumnType("int");

                    b.Property<string>("RestAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("RestID");

                    b.HasIndex("ApprovalID");

                    b.HasIndex("CityID");

                    b.HasIndex("RoleID");

                    b.ToTable("restaurantsRegiiss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roleess");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.State", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateID"), 1L, 1);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("Stateess");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.TableBooking", b =>
                {
                    b.Property<int>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableID"), 1L, 1);

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("TableID");

                    b.ToTable("TableBookingss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<int?>("ApprovalID")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserAge")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("ApprovalID");

                    b.HasIndex("CityID");

                    b.HasIndex("RoleID");

                    b.ToTable("Userrss");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Cart", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.TableBooking", "TableBooking")
                        .WithMany()
                        .HasForeignKey("TableBookingTableID");

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.RestaurantsRegi", "restaurantsRegi")
                        .WithMany()
                        .HasForeignKey("restaurantsRegiRestID");

                    b.Navigation("Food");

                    b.Navigation("TableBooking");

                    b.Navigation("User");

                    b.Navigation("restaurantsRegi");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.City", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Food", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.FoodCategory", "FoodCategory")
                        .WithMany()
                        .HasForeignKey("FoodCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.Payment", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.CustomerOrder", "CustomerOrder")
                        .WithMany()
                        .HasForeignKey("CustomerOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerOrder");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.RestaurantsRegi", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Approval", "Approval")
                        .WithMany()
                        .HasForeignKey("ApprovalID");

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.Navigation("Approval");

                    b.Navigation("City");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.State", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Restaurants_MinimalAPI_Mediator.Model.User", b =>
                {
                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Approval", "Approval")
                        .WithMany()
                        .HasForeignKey("ApprovalID");

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurants_MinimalAPI_Mediator.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Approval");

                    b.Navigation("City");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
