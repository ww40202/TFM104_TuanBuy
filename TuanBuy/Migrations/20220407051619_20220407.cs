using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _20220407 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 16, 18, 989, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 16, 18, 990, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 16, 18, 990, DateTimeKind.Local).AddTicks(4054));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 8, 9, 696, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 8, 9, 697, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 7, 13, 8, 9, 697, DateTimeKind.Local).AddTicks(6952));
        }
    }
}
