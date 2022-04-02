using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class _0402 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatRoomMember_ChatRoom_ChatRoomId",
                table: "ChatRoomMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatRoomMember_User_MemberId",
                table: "ChatRoomMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatRoomMember",
                table: "ChatRoomMember");

            migrationBuilder.RenameTable(
                name: "ChatRoomMember",
                newName: "Member_Chats");

            migrationBuilder.RenameIndex(
                name: "IX_ChatRoomMember_ChatRoomId",
                table: "Member_Chats",
                newName: "IX_Member_Chats_ChatRoomId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Member_Chats",
                table: "Member_Chats",
                columns: new[] { "MemberId", "ChatRoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Chats_ChatRoom_ChatRoomId",
                table: "Member_Chats",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Chats_User_MemberId",
                table: "Member_Chats",
                column: "MemberId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Chats_ChatRoom_ChatRoomId",
                table: "Member_Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Chats_User_MemberId",
                table: "Member_Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Member_Chats",
                table: "Member_Chats");

            migrationBuilder.RenameTable(
                name: "Member_Chats",
                newName: "ChatRoomMember");

            migrationBuilder.RenameIndex(
                name: "IX_Member_Chats_ChatRoomId",
                table: "ChatRoomMember",
                newName: "IX_ChatRoomMember_ChatRoomId");

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatRoomMember",
                table: "ChatRoomMember",
                columns: new[] { "MemberId", "ChatRoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRoomMember_ChatRoom_ChatRoomId",
                table: "ChatRoomMember",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRoomMember_User_MemberId",
                table: "ChatRoomMember",
                column: "MemberId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
