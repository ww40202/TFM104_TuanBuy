using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _410 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 10, 1, 21, 29, 623, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 10, 1, 21, 29, 624, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 10, 1, 21, 29, 624, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 10, 1, 21, 29, 624, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Address", "CreateDate", "Description", "Disable", "PaymentType", "Phone", "StateId", "UserId" },
                values: new object[,]
                {
                    { 5, "送貨地址", new DateTime(2022, 4, 10, 1, 21, 29, 624, DateTimeKind.Local).AddTicks(8923), "Benny跟Harry購買產品", false, 1, "0987654", 1, 5 },
                    { 6, "送貨地址", new DateTime(2022, 4, 10, 1, 21, 29, 624, DateTimeKind.Local).AddTicks(8972), "Linn跟Harry購買產品", false, 1, "0987654", 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 610, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 4, 20, 1, 21, 29, 611, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6053), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6232), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6365), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6469), new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Content", "CreateTime", "Description", "Disable", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { 8, "食品", "堅持手工製作，外酥內Q的迷人口感，多種披薩口味任選，簡單加熱就能享用，香氣濃郁成份單純，點心宵夜絕對便利的美味～", new DateTime(2022, 4, 10, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6533), "堅持手工製作，外酥內Q的迷人口感，多種披薩口味任選，簡單加熱就能享用，香氣濃郁成份單純，點心宵夜絕對便利的美味～", false, new DateTime(2022, 4, 20, 1, 21, 29, 619, DateTimeKind.Local).AddTicks(6535), "魔法仗", 300m, 20000m, 6 });

            migrationBuilder.InsertData(
                table: "ProductPics",
                columns: new[] { "Id", "PicPath", "ProductId" },
                values: new object[] { 9, "DEMO牛排1.jpg", 5 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderId", "ProductId", "Count", "Disable", "Price" },
                values: new object[] { 5, 8, 50, false, 1500m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderId", "ProductId", "Count", "Disable", "Price" },
                values: new object[] { 6, 8, 3, false, 1500m });

            migrationBuilder.UpdateData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PicPath", "ProductId" },
                values: new object[] { "Demo二哈.jpg", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 16, 52, 58, 589, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 16, 52, 58, 594, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 16, 52, 58, 594, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 16, 52, 58, 594, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 559, DateTimeKind.Local).AddTicks(7835), new DateTime(2022, 4, 19, 16, 52, 58, 561, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(5891), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6747), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6917), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 4, 19, 16, 52, 58, 579, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PicPath", "ProductId" },
                values: new object[] { "DEMO牛排1.jpg", 5 });
        }
    }
}
