using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _2080 : Migration
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
                value: new DateTime(2022, 4, 8, 22, 17, 30, 2, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 17, 30, 4, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 984, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 4, 18, 22, 17, 29, 985, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(653), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(774), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(859), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(906), new DateTime(2022, 4, 18, 22, 17, 29, 994, DateTimeKind.Local).AddTicks(907) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
