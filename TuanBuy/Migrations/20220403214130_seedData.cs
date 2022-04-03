using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "BankAccount", "Birth", "Disable", "Email", "Friend", "Name", "NickName", "Password", "Phone", "PicPath", "Sex", "State" },
                values: new object[] { 1, null, null, null, false, "123@gmail.com", null, "小王", "小王", "123456", null, "637843188933582087init.jpg", 1, "正式會員" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "BankAccount", "Birth", "Disable", "Email", "Friend", "Name", "NickName", "Password", "Phone", "PicPath", "Sex", "State" },
                values: new object[] { 2, null, null, null, false, "456@gmail.com", null, "小王", "小王", "123456", null, "637843188933582087init.jpg", 1, "正式會員" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "BankAccount", "Birth", "Disable", "Email", "Friend", "Name", "NickName", "Password", "Phone", "PicPath", "Sex", "State" },
                values: new object[] { 3, null, null, null, false, "789@gmail.com", null, "小王", "小王", "123456", null, "637843188933582087init.jpg", 1, "正式會員" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
