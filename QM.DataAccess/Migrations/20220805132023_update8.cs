using Microsoft.EntityFrameworkCore.Migrations;

namespace QM.DataAccess.Migrations
{
    public partial class update8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FQControlBase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManualControlSaved = table.Column<bool>(type: "bit", nullable: false),
                    ManualControlSuccess = table.Column<bool>(type: "bit", nullable: false),
                    OpenControlSaved = table.Column<bool>(type: "bit", nullable: false),
                    OpenControlSuccess = table.Column<bool>(type: "bit", nullable: false),
                    CloseControlSaved = table.Column<bool>(type: "bit", nullable: false),
                    CloseControlSuccess = table.Column<bool>(type: "bit", nullable: false),
                    PackageControlSaved = table.Column<bool>(type: "bit", nullable: false),
                    PackageControlSuccess = table.Column<bool>(type: "bit", nullable: false),
                    FinalQualityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FQControlBase", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FQControlBase");
        }
    }
}
