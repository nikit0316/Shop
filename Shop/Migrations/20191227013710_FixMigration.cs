using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class FixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "OrderDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "OrderDetail",
                type: "text",
                nullable: true);
        }
    }
}
