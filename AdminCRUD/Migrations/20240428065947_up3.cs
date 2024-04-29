using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCRUD.Migrations
{
    public partial class up3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("News");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
