using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 46, 43, 129, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 46, 43, 132, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 46, 43, 132, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 46, 43, 132, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 4, 8, 22, 46, 43, 132, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Address", "CreateDate", "Description", "Disable", "PaymentType", "Phone", "StateId", "UserId" },
                values: new object[] { 6, "送貨地址", new DateTime(2022, 4, 8, 22, 46, 43, 132, DateTimeKind.Local).AddTicks(348), "Linn跟Harry購買產品", false, 1, "0987654", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 114, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 4, 18, 22, 46, 43, 114, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4554), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4835), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5009), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5404), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5759), new DateTime(2022, 4, 18, 22, 46, 43, 122, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderId", "ProductId", "Count", "Disable", "Price" },
                values: new object[] { 6, 8, 3, false, 1500m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);

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
                columns: new[] { "CreateTime", "EndTime" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(3028), new DateTime(2022, 4, 18, 22, 43, 30, 472, DateTimeKind.Local).AddTicks(3029) });
        }
    }
}
