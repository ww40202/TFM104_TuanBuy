using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _2090 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 395, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 380, DateTimeKind.Local).AddTicks(1042), new DateTime(2022, 4, 18, 22, 38, 32, 380, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9237), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9472), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9616), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Content", "CreateTime", "Description", "Disable", "EndTime", "Name", "Price", "Total", "UserId" },
                values: new object[] { 8, "食品", "堅持手工製作，外酥內Q的迷人口感，多種披薩口味任選，簡單加熱就能享用，香氣濃郁成份單純，點心宵夜絕對便利的美味～", new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9715), "堅持手工製作，外酥內Q的迷人口感，多種披薩口味任選，簡單加熱就能享用，香氣濃郁成份單純，點心宵夜絕對便利的美味～", false, new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9716), "魔法仗", 300m, 10000m, 6 });

            migrationBuilder.InsertData(
                table: "ProductPics",
                columns: new[] { "Id", "PicPath", "ProductId" },
                values: new object[] { 8, "Demo二哈.jpg", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 2, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 984, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 4, 18, 22, 17, 29, 985, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(653), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(774), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(859), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(906), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(907) });
        }
    }
}
