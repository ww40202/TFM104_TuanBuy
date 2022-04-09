using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _0408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
