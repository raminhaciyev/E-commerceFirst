using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class miguser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewUsers",
                columns: table => new
                {
                    NewUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    NewUserMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewUserStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUsers", x => x.NewUserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewUsers");
        }
    }
}
