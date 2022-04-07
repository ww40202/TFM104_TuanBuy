using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class Test0406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total" },
                values: new object[] { "食品", "不知道可不可以吃的貓咪", new DateTime(2022, 4, 7, 14, 36, 57, 178, DateTimeKind.Local).AddTicks(1708), "不知道可不可以吃", new DateTime(2022, 4, 12, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(1868), "貓貓", 50m, 1000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { "食品", "可以吃的生鮮鮭魚", new DateTime(2022, 4, 7, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2492), "便宜好吃的鮭魚", new DateTime(2022, 4, 13, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2499), "鮭魚", 50m, 500m, 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { "3C", "便宜好用ㄉ記憶體", new DateTime(2022, 4, 7, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2526), "記憶體是要描述什麼", new DateTime(2022, 4, 10, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2528), "記憶體", 3000m, 10000m, 3 });

            migrationBuilder.InsertData(
                table: "ProductPics",
                columns: new[] { "Id", "PicPath", "ProductId" },
                values: new object[,]
                {
                    { 1, "DEMO喵喵.jpg", 1 },
                    { 2, "DEMO鮭魚.jpg", 2 },
                    { 3, "DEMO記憶體.jpg", 3 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "NickName",
                value: "賣貓的小王");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "NickName",
                value: "賣鮭魚的小明");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "NickName",
                value: "賣記憶體的小張");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total" },
                values: new object[] { "測試類別", "商品內容", new DateTime(2022, 4, 7, 13, 2, 11, 737, DateTimeKind.Local).AddTicks(5801), "商品描述", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品1", 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { "測試類別", "商品內容", new DateTime(2022, 4, 7, 13, 2, 11, 739, DateTimeKind.Local).AddTicks(4563), "商品描述", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品2", 0m, 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Content", "CreateTime", "Description", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { "測試類別", "商品內容", new DateTime(2022, 4, 7, 13, 2, 11, 739, DateTimeKind.Local).AddTicks(4635), "商品描述", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品3", 0m, 0m, 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "NickName",
                value: "小王");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "NickName",
                value: "小明");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "NickName",
                value: "小張");
        }
    }
}
