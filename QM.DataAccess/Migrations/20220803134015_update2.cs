using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QM.DataAccess.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Control14",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control15",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control16",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control17",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control18",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control19",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control20",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control21",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control22",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control23",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control24",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control25",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control26",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control27",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control28",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control29",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control30",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control31",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control32",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control33",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control34",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control35",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Control36",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status14",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status15",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status16",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status17",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status18",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status19",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status20",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status21",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status22",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status23",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status24",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status25",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status26",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status27",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status28",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status29",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status30",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status31",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status32",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status33",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status34",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "Status35",
                table: "FQControls");

            migrationBuilder.RenameColumn(
                name: "Status36",
                table: "FQControls",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "FQControls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RevisionNo",
                table: "FQControls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FQControls2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionNo = table.Column<int>(type: "int", nullable: false),
                    Status14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Control36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalQualityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FQControls2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FQControls2_FinalQualities_FinalQualityId",
                        column: x => x.FinalQualityId,
                        principalTable: "FinalQualities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FQControls2_FinalQualityId",
                table: "FQControls2",
                column: "FinalQualityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FQControls2");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "FQControls");

            migrationBuilder.DropColumn(
                name: "RevisionNo",
                table: "FQControls");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FQControls",
                newName: "Status36");

            migrationBuilder.AddColumn<string>(
                name: "Control14",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control15",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control16",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control17",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control18",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control19",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control20",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control21",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control22",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control23",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control24",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control25",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control26",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control27",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control28",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control29",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control30",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control31",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control32",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control33",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control34",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control35",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control36",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status14",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status15",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status16",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status17",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status18",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status19",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status20",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status21",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status22",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status23",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status24",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status25",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status26",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status27",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status28",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status29",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status30",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status31",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status32",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status33",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status34",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status35",
                table: "FQControls",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
