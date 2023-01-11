using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryPRojectFull.Server.Data.Migrations
{
    public partial class Addedfixagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d6ff59a-9f53-4128-801b-2f1c8630aa69", "ec9f4dc1-a152-4966-8e67-4ea82594e77a", "Administrator", "ADMINISTRATOR" },
                    { "75a8c3ae-282b-4c8a-88c2-be8c0cd23659", "dd101968-bf41-44f3-beda-43c55bd6a2ed", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0ad66375-7be5-4cb8-806e-c9ad74dc781d", 0, "64f5ecfe-12bc-4ae9-9084-97ac9e113335", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEMsbtxqVGGvAJzSbmjsQyIqHlxW9zNV8mrQhLg6C3pWih89wlMJCUirbDIA+wi2tSQ==", null, false, "2488ea03-72ee-4262-9434-f5fa3df2726f", false, "Admin" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d6ff59a-9f53-4128-801b-2f1c8630aa69", "0ad66375-7be5-4cb8-806e-c9ad74dc781d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a8c3ae-282b-4c8a-88c2-be8c0cd23659");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d6ff59a-9f53-4128-801b-2f1c8630aa69", "0ad66375-7be5-4cb8-806e-c9ad74dc781d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d6ff59a-9f53-4128-801b-2f1c8630aa69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ad66375-7be5-4cb8-806e-c9ad74dc781d");

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 554, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 1, 11, 16, 1, 53, 556, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(333), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 1, 11, 16, 1, 53, 557, DateTimeKind.Local).AddTicks(378) });
        }
    }
}
