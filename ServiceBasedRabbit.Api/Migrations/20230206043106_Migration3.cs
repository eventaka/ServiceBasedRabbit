using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceBasedRabbit.Api.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Item_ItemId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ItemId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_UserId",
                table: "Item",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_User_UserId",
                table: "Item",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_User_UserId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_UserId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ItemId",
                table: "User",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Item_ItemId",
                table: "User",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
