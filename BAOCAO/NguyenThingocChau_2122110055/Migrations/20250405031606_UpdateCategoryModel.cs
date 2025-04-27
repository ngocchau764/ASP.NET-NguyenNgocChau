using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThingocChau_2122110055.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Update_by");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Categories",
                newName: "Delete_by");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Create_by");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "Category_id");

            migrationBuilder.AddColumn<int>(
                name: "Category_id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Create_at",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Create_by",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Delete_at",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Delete_by",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_at",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Update_by",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category_name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Create_at",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Delete_at",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_at",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_id",
                table: "Products",
                column: "Category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_id",
                table: "Products",
                column: "Category_id",
                principalTable: "Categories",
                principalColumn: "Category_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Create_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Create_by",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Delete_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Delete_by",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Update_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Update_by",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category_name",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Create_at",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Delete_at",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Update_at",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Update_by",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Delete_by",
                table: "Categories",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Create_by",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Category_id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
