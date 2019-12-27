using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class NavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderId",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "OrderDetail",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_orderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_Orderid");

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "OrderDetail",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "detailid",
                table: "Order",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_detailid",
                table: "Order",
                column: "detailid");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderDetail_detailid",
                table: "Order",
                column: "detailid",
                principalTable: "OrderDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_Orderid",
                table: "OrderDetail",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderDetail_detailid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_Orderid",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_Order_detailid",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "detailid",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderDetail",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_Orderid",
                table: "OrderDetail",
                newName: "IX_OrderDetail_orderId");

            migrationBuilder.AlterColumn<int>(
                name: "orderId",
                table: "OrderDetail",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderId",
                table: "OrderDetail",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
