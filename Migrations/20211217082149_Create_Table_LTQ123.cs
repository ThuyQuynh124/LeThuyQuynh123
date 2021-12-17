using Microsoft.EntityFrameworkCore.Migrations;

namespace LeThuyQuynh123.Migrations
{
    public partial class Create_Table_LTQ123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LTQ",
                columns: table => new
                {
                    LTQId = table.Column<string>(type: "TEXT", nullable: false),
                    LTQName = table.Column<string>(type: "TEXT", nullable: true),
                    LTQGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LTQ", x => x.LTQId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LTQ");
        }
    }
}
