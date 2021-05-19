using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSocialMediaDb.Migrations
{
    public partial class AddedFollowingUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FollowedUser",
                columns: table => new
                {
                    FollowingUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserTofollow = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedUser", x => new { x.FollowingUser, x.UserTofollow });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowedUser");
        }
    }
}
