using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryPRojectFull.Server.Data.Migrations
{
    public partial class AddedFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_payment_paymentId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment",
                table: "payment");

            migrationBuilder.RenameTable(
                name: "payment",
                newName: "Payment");

            migrationBuilder.RenameColumn(
                name: "svc",
                table: "Payment",
                newName: "Svc");

            migrationBuilder.RenameColumn(
                name: "expire",
                table: "Payment",
                newName: "Expire");

            migrationBuilder.RenameColumn(
                name: "paymentId",
                table: "Customer",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_paymentId",
                table: "Customer",
                newName: "IX_Customer_PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Payment_PaymentId",
                table: "Customer",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Payment_PaymentId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "payment");

            migrationBuilder.RenameColumn(
                name: "Svc",
                table: "payment",
                newName: "svc");

            migrationBuilder.RenameColumn(
                name: "Expire",
                table: "payment",
                newName: "expire");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Customer",
                newName: "paymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_PaymentId",
                table: "Customer",
                newName: "IX_Customer_paymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment",
                table: "payment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_payment_paymentId",
                table: "Customer",
                column: "paymentId",
                principalTable: "payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
