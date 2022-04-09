using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class test0409 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 23, 59, 11, 798, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 23, 59, 11, 800, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 23, 59, 11, 800, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 23, 59, 11, 800, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 790, DateTimeKind.Local).AddTicks(937), new DateTime(2022, 4, 19, 23, 59, 11, 790, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2320), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2438), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 4, 19, 23, 59, 11, 796, DateTimeKind.Local).AddTicks(2495) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 41, 16, 434, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 41, 16, 438, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 41, 16, 438, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 41, 16, 438, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 412, DateTimeKind.Local).AddTicks(7087), new DateTime(2022, 4, 19, 9, 41, 16, 414, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7445), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7553), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7649), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7809), new DateTime(2022, 4, 19, 9, 41, 16, 427, DateTimeKind.Local).AddTicks(7811) });
        }
    }
}
