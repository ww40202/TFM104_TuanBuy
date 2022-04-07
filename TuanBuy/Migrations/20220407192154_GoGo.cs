using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class GoGo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 21, 54, 0, DateTimeKind.Local).AddTicks(3974), new DateTime(2022, 4, 13, 3, 21, 54, 1, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 21, 54, 1, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 4, 14, 3, 21, 54, 1, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 21, 54, 1, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 4, 11, 3, 21, 54, 1, DateTimeKind.Local).AddTicks(2106) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(714), new DateTime(2022, 4, 13, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(8591), new DateTime(2022, 4, 14, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 4, 11, 3, 2, 16, 735, DateTimeKind.Local).AddTicks(8618) });
        }
    }
}
