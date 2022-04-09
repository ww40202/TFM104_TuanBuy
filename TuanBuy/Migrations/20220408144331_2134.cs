using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _2134 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 43, 30, 475, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 43, 30, 477, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 43, 30, 477, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 43, 30, 477, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 43, 30, 477, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 462, DateTimeKind.Local).AddTicks(732), new DateTime(2022, 4, 18, 22, 43, 30, 463, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2519), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2755), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2822), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime", "Total" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(3028), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(3029), 20000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 42, 19, 678, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 42, 19, 679, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 42, 19, 679, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 42, 19, 679, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 42, 19, 679, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 657, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 4, 18, 22, 42, 19, 658, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(544), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1052), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1146), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime", "Total" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1406), 10000m });
        }
    }
}
