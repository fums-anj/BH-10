using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BH.DataAccess.Migrations
{
    public partial class espancechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseMonths_ExpenseMonthId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseYears_ExpenseYearId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpenseMonthId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpenseYearId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseMonthId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseYearId",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "GlobalNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 17, 45, 35, 274, DateTimeKind.Local).AddTicks(7051));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseMonthId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpenseYearId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GlobalNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 15, 21, 49, 729, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseMonthId",
                table: "Expenses",
                column: "ExpenseMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseYearId",
                table: "Expenses",
                column: "ExpenseYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseMonths_ExpenseMonthId",
                table: "Expenses",
                column: "ExpenseMonthId",
                principalTable: "ExpenseMonths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseYears_ExpenseYearId",
                table: "Expenses",
                column: "ExpenseYearId",
                principalTable: "ExpenseYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
