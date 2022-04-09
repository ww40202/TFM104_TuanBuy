using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 31, 12, 649, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 31, 12, 651, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 31, 12, 651, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 9, 31, 12, 651, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 626, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 4, 19, 9, 31, 12, 627, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3616), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3937), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(4051), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 4, 19, 9, 31, 12, 643, DateTimeKind.Local).AddTicks(4212) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 402, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 385, DateTimeKind.Local).AddTicks(2801), new DateTime(2022, 4, 18, 23, 50, 13, 386, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6342), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6568), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6729), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6862), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6864) });
        }
    }
}
