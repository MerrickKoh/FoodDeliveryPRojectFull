using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryPRojectFull.Server.Data.Migrations
{
    public partial class AddedFoodFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOrders");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Food",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d6ff59a-9f53-4128-801b-2f1c8630aa69",
                column: "ConcurrencyStamp",
                value: "3e63436c-e7f4-42d4-987c-e314db417c23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a8c3ae-282b-4c8a-88c2-be8c0cd23659",
                column: "ConcurrencyStamp",
                value: "fe3872f9-c371-442b-9516-cb37d1140fc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ad66375-7be5-4cb8-806e-c9ad74dc781d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dcff43f-6cbc-481f-8476-a56e5ea19e14", "AQAAAAEAACcQAAAAEAWnuNE2k1aBHoljsXXU3BRj8OLO65OKIm6RCjghVGsrWTkL2gaRK3kFFBFOwGeBWg==", "ab8a6df4-0b07-4f27-8fe4-64385db2c34c" });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 423, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 1, 13, 12, 2, 43, 423, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(73), new DateTime(2023, 1, 13, 12, 2, 43, 424, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FoodId",
                table: "Orders",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_OrdersId",
                table: "Food",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Orders_OrdersId",
                table: "Food",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Food_FoodId",
                table: "Orders",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Orders_OrdersId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Food_FoodId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FoodId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Food_OrdersId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Food");

            migrationBuilder.CreateTable(
                name: "FoodOrders",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrders", x => new { x.FoodId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_FoodOrders_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrders_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d6ff59a-9f53-4128-801b-2f1c8630aa69",
                column: "ConcurrencyStamp",
                value: "ec9f4dc1-a152-4966-8e67-4ea82594e77a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a8c3ae-282b-4c8a-88c2-be8c0cd23659",
                column: "ConcurrencyStamp",
                value: "dd101968-bf41-44f3-beda-43c55bd6a2ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ad66375-7be5-4cb8-806e-c9ad74dc781d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64f5ecfe-12bc-4ae9-9084-97ac9e113335", "AQAAAAEAACcQAAAAEMsbtxqVGGvAJzSbmjsQyIqHlxW9zNV8mrQhLg6C3pWih89wlMJCUirbDIA+wi2tSQ==", "2488ea03-72ee-4262-9434-f5fa3df2726f" });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 201, DateTimeKind.Local).AddTicks(6929), new DateTime(2023, 1, 11, 16, 7, 1, 203, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 1, 11, 16, 7, 1, 204, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_OrdersId",
                table: "FoodOrders",
                column: "OrdersId");
        }
    }
}
