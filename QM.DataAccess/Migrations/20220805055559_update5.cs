using Microsoft.EntityFrameworkCore.Migrations;

namespace QM.DataAccess.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusFQC1",
                table: "FinalQualities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusFQC2",
                table: "FinalQualities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusFQMC",
                table: "FinalQualities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusFQPC",
                table: "FinalQualities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusFQC1",
                table: "FinalQualities");

            migrationBuilder.DropColumn(
                name: "StatusFQC2",
                table: "FinalQualities");

            migrationBuilder.DropColumn(
                name: "StatusFQMC",
                table: "FinalQualities");

            migrationBuilder.DropColumn(
                name: "StatusFQPC",
                table: "FinalQualities");
        }
    }
}
