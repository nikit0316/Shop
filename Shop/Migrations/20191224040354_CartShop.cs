using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class CartShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "ShopCartItem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "ShopCartItem");
        }
    }
}
