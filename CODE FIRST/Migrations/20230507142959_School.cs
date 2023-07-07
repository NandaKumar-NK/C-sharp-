using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CODE_FIRST.Migrations
{
    /// <inheritdoc />
    public partial class School : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stds",
                columns: table => new
                {
                    stdRoll = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stddept = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stds", x => x.stdRoll);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stds");
        }
    }
}
