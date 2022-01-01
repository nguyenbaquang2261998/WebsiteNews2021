using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class AddColumnForTableNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeyword",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "News");

            migrationBuilder.DropColumn(
                name: "MetaKeyword",
                table: "News");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "News");
        }
    }
}
