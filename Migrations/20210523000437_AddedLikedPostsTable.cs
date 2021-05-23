using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSocialMediaDb.Migrations
{
    public partial class AddedLikedPostsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LikedPost",
                columns: table => new
                {
                    LikingUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedPost", x => new { x.LikingUser, x.PostId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikedPost");
        }
    }
}
