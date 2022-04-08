using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class 更新牛排 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentType",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 402, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 23, 50, 13, 403, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 385, DateTimeKind.Local).AddTicks(2801), new DateTime(2022, 4, 18, 23, 50, 13, 386, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6342), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6568), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6729), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6862), new DateTime(2022, 4, 18, 23, 50, 13, 393, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.InsertData(
                table: "ProductPics",
                columns: new[] { "Id", "PicPath", "ProductId" },
                values: new object[] { 8, "DEMO牛排1.jpg", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentType",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 16, 3, 50, 391, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 16, 3, 50, 392, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 16, 3, 50, 392, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 16, 3, 50, 392, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 382, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 4, 18, 16, 3, 50, 383, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6067), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6229), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 4, 18, 16, 3, 50, 388, DateTimeKind.Local).AddTicks(6425) });
        }
    }
}
