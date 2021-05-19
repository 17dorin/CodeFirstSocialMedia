using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSocialMediaDb.Migrations
{
    public partial class PostsToUserRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AspNetUserId",
                table: "Posts",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AspNetUserId",
                table: "Posts",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AspNetUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AspNetUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Posts");
        }
    }
}
