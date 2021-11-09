using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class CreateColumnCoverImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "News");
        }
    }
}
