using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _0406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 14, 32, 35, 417, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 14, 32, 35, 418, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 14, 32, 35, 418, DateTimeKind.Local).AddTicks(2478));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 9, 36, 11, 521, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 9, 36, 11, 522, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 6, 9, 36, 11, 522, DateTimeKind.Local).AddTicks(7404));
        }
    }
}
