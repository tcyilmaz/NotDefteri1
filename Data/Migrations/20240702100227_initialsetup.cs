using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotDefteri1.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Note",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                noteTitle = table.Column<string>(nullable: true),
                noteDescription = table.Column<string>(nullable: true),
                noteDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()")
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Joke", x => x.Id);
            }
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Note");
        }
    }
}
