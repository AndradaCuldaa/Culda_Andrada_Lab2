using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Culda_Andrada_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryIDToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryID",
                table: "Book",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_CategoryID",
                table: "Book",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_CategoryID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_CategoryID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Book",
                newName: "Id");
        }
    }
}
