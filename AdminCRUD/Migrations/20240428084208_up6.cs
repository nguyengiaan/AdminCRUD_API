using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCRUD.Migrations
{
    public partial class up6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
             name: "Title",
             table: "Tintuc",
             nullable: true);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
