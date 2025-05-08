using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaKing.Migrations
{
    /// <inheritdoc />
    public partial class PizzaAddIsInStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 46, 35, 36, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 46, 35, 36, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 46, 35, 36, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 46, 35, 36, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsInStock",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsInStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsInStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsInStock",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsInStock",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsInStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsInStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsInStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsInStock",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsInStock",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Pizzas");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTimeUTC",
                value: new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350));
        }
    }
}
