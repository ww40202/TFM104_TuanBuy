using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Address", "CreateDate", "Description", "Disable", "PaymentType", "Phone", "StateId", "UserId" },
                values: new object[] { 5, "送貨地址", new DateTime(2022, 4, 8, 22, 42, 19, 679, DateTimeKind.Local).AddTicks(8746), "Benny跟Harry購買產品", false, 1, "0987654", 1, 5 });

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
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 4, 18, 22, 42, 19, 670, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderId", "ProductId", "Count", "Disable", "Price" },
                values: new object[] { 5, 8, 50, false, 1500m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 395, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 38, 32, 397, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 380, DateTimeKind.Local).AddTicks(1042), new DateTime(2022, 4, 18, 22, 38, 32, 380, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9237), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9472), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9616), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9715), new DateTime(2022, 4, 18, 22, 38, 32, 387, DateTimeKind.Local).AddTicks(9716) });
        }
    }
}
