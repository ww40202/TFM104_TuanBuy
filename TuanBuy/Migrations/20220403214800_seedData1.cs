using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class seedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Content", "CreateTime", "Description", "Disable", "EndTime", "Name", "PicPath", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, "測試類別", "商品內容", new DateTime(2022, 4, 4, 5, 47, 59, 862, DateTimeKind.Local).AddTicks(1062), "商品描述", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品1", null, 0m, 1 },
                    { 2, "測試類別", "商品內容", new DateTime(2022, 4, 4, 5, 47, 59, 862, DateTimeKind.Local).AddTicks(9106), "商品描述", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品2", null, 0m, 1 },
                    { 3, "測試類別", "商品內容", new DateTime(2022, 4, 4, 5, 47, 59, 862, DateTimeKind.Local).AddTicks(9139), "商品描述", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "測試商品3", null, 0m, 1 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NickName" },
                values: new object[] { "小明", "小明" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NickName" },
                values: new object[] { "小張", "小張" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NickName" },
                values: new object[] { "小王", "小王" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NickName" },
                values: new object[] { "小王", "小王" });
        }
    }
}
