using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 56, 39, 51, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 4, 12, 20, 56, 39, 52, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 56, 39, 52, DateTimeKind.Local).AddTicks(1759), new DateTime(2022, 4, 13, 20, 56, 39, 52, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 56, 39, 52, DateTimeKind.Local).AddTicks(1799), new DateTime(2022, 4, 10, 20, 56, 39, 52, DateTimeKind.Local).AddTicks(1801) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 55, 59, 987, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 4, 12, 20, 55, 59, 988, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 55, 59, 988, DateTimeKind.Local).AddTicks(8778), new DateTime(2022, 4, 13, 20, 55, 59, 988, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 20, 55, 59, 988, DateTimeKind.Local).AddTicks(8815), new DateTime(2022, 4, 10, 20, 55, 59, 988, DateTimeKind.Local).AddTicks(8817) });
        }
    }
}
