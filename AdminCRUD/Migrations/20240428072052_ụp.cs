using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCRUD.Migrations
{
    public partial class ụp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tintuc",
                columns: table => new
                {
                    Id_News = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tintuc", x => x.Id_News);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
           
        }
    }
}
