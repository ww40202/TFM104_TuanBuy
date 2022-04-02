using Microsoft.EntityFrameworkCore.Migrations;

namespace TuanBuy.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatRoom_ChatRoomId",
                table: "ChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatRoomUser_ChatRoom_ChatRoomId",
                table: "ChatRoomUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Chats_ChatRoom_ChatRoomId",
                table: "Member_Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatRoom",
                table: "ChatRoom");

            migrationBuilder.RenameTable(
                name: "ChatRoom",
                newName: "ChatRooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatRooms",
                table: "ChatRooms",
                column: "ChatRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatRooms_ChatRoomId",
                table: "ChatMessages",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRoomUser_ChatRooms_ChatRoomId",
                table: "ChatRoomUser",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Chats_ChatRooms_ChatRoomId",
                table: "Member_Chats",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatRooms_ChatRoomId",
                table: "ChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatRoomUser_ChatRooms_ChatRoomId",
                table: "ChatRoomUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Chats_ChatRooms_ChatRoomId",
                table: "Member_Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatRooms",
                table: "ChatRooms");

            migrationBuilder.RenameTable(
                name: "ChatRooms",
                newName: "ChatRoom");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatRoom",
                table: "ChatRoom",
                column: "ChatRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatRoom_ChatRoomId",
                table: "ChatMessages",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRoomUser_ChatRoom_ChatRoomId",
                table: "ChatRoomUser",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Chats_ChatRoom_ChatRoomId",
                table: "Member_Chats",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "ChatRoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
