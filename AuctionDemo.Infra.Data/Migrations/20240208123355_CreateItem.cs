using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionDemo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Auctions_AuctionId1",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_AuctionId1",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AuctionId1",
                table: "Item");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuctionId",
                table: "Item",
                type: "uuid using \"Id\"::uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Item_AuctionId",
                table: "Item",
                column: "AuctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Auctions_AuctionId",
                table: "Item",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Auctions_AuctionId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_AuctionId",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "AuctionId",
                table: "Item",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "AuctionId1",
                table: "Item",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_AuctionId1",
                table: "Item",
                column: "AuctionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Auctions_AuctionId1",
                table: "Item",
                column: "AuctionId1",
                principalTable: "Auctions",
                principalColumn: "Id");
        }
    }
}
