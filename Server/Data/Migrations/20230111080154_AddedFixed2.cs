using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryPRojectFull.Server.Data.Migrations
{
    public partial class AddedFixed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catergory",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 11, 16, 1, 53, 554, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 1, 11, 16, 1, 53, 556, DateTimeKind.Local).AddTicks(8258), "Sushi", "System" },
                    { 2, "System", new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(333), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(355), "Ramen", "System" },
                    { 3, "System", new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(363), "Curry", "System" },
                    { 4, "System", new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(369), "Bento", "System" },
                    { 5, "System", new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(373), "Soup", "System" },
                    { 6, "System", new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(378), "Drinks", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
