using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaKing.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comments", "CreateTimeUTC", "Email", "Name" },
                values: new object[,]
                {
                { 1, "真不錯", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9210), "noname1@hotmail.com", "阿萊克斯" },
                 { 2, "還是挺好吃的", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname2@hotmail.com", "萊克斯" },
                 { 3, "啥輪七八糟的", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname3@hotmail.com", "克斯" },
                 { 4, "厚切的才有嚼勁", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname4@hotmail.com", "克斯" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "/images/毛細.png", "真的全是香腸啊", "香腸披薩", 12m, "全是香腸" },
                     { 2, "/images/細.​​png", "蔬菜什錦還有大魚大肉", "什錦披薩", 10m, "全部都有" },
                     { 3, "/images/三細.png", "可以拉絲的起司披薩", "起司披薩", 11m, "濃濃的起司起司" },
                     { 4, "/images/二細.png", "義大利人的惡夢", "夏威夷披薩", 10m, "有鳳梨" },
                     { 5, "/images/二柱.png", "全國人民的最愛", "小龍蝦披薩", 11m, "麻辣小龍蝦口味" },
                     { 6, "/images/韭葉子.png", "瞎編的", "鹹蛋黃蝦仁披薩", 12m, "啥" },
                     { 7, "/images/薄寬.png", "還是我瞎編的", "川式臘味披薩", 11m, "啥啥" },
                     { 8, "/images/大寬.png", "面上加面碳水爆炸", "螺獅粉披薩", 10m, "臭臭的披薩" },
                     { 9, "/images/蕎麥棱子.png", "可能也不太正宗", "正宗意大利披薩", 15m, "薄低番茄口" },
                     { 10, "/images/一窩絲.png", "應該還不錯吧", "好吃的披薩", 15m, "從必勝客打包來的" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
