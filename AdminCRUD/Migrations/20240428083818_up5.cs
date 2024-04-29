using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCRUD.Migrations
{
    public partial class up5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
            name: "Image",
            table: "Tintuc",
             nullable: true, // Cho phép giá trị null
             oldNullable: false); // Giữ nguyên các thiết lập cũ
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
