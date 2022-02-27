using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class deletecommenidmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewUsers_Comments_CommentID",
                table: "NewUsers");

            migrationBuilder.DropIndex(
                name: "IX_NewUsers_CommentID",
                table: "NewUsers");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "NewUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "NewUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NewUsers_CommentID",
                table: "NewUsers",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_NewUsers_Comments_CommentID",
                table: "NewUsers",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "CommentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
