using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class demo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 17, 23, 21, 552, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 4, 12, 17, 23, 21, 553, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 17, 23, 21, 553, DateTimeKind.Local).AddTicks(8036), new DateTime(2022, 4, 13, 17, 23, 21, 553, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 17, 23, 21, 553, DateTimeKind.Local).AddTicks(8078), new DateTime(2022, 4, 10, 17, 23, 21, 553, DateTimeKind.Local).AddTicks(8081) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 14, 36, 57, 178, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 4, 12, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 4, 13, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 7, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2526), new DateTime(2022, 4, 10, 14, 36, 57, 179, DateTimeKind.Local).AddTicks(2528) });
        }
    }
}
