using Microsoft.EntityFrameworkCore.Migrations;

namespace QM.DataAccess.Migrations
{
    public partial class update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Permit",
                table: "FinalQualities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StatusM",
                table: "FinalQualities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StatusQO",
                table: "FinalQualities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permit",
                table: "FinalQualities");

            migrationBuilder.DropColumn(
                name: "StatusM",
                table: "FinalQualities");

            migrationBuilder.DropColumn(
                name: "StatusQO",
                table: "FinalQualities");
        }
    }
}
