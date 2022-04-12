using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _0412l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 346, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 348, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 348, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 348, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 348, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 18, 54, 36, 348, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 331, DateTimeKind.Local).AddTicks(9310), new DateTime(2022, 4, 22, 18, 54, 36, 332, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(7771), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(7906), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8009), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8069), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8128), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8184), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8241), new DateTime(2022, 4, 22, 18, 54, 36, 338, DateTimeKind.Local).AddTicks(8242) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 268, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 271, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 271, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 271, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 271, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 4, 12, 15, 59, 45, 271, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 253, DateTimeKind.Local).AddTicks(1544), new DateTime(2022, 4, 22, 15, 59, 45, 253, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4567), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4632), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 12, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 4, 22, 15, 59, 45, 262, DateTimeKind.Local).AddTicks(4839) });
        }
    }
}
