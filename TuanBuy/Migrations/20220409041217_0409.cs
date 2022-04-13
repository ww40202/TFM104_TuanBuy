using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _0409 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 12, 12, 16, 320, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 12, 12, 16, 322, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 12, 12, 16, 322, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 9, 12, 12, 16, 322, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 305, DateTimeKind.Local).AddTicks(2215), new DateTime(2022, 4, 19, 12, 12, 16, 305, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6631), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6882), new DateTime(2022, 4, 19, 12, 12, 16, 314, DateTimeKind.Local).AddTicks(6884) });
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
