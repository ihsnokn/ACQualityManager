using Microsoft.EntityFrameworkCore.Migrations;

namespace QM.DataAccess.Migrations
{
    public partial class upadate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "FQControls2",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "FQControls",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "FQControls2");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "FQControls");
        }
    }
}
