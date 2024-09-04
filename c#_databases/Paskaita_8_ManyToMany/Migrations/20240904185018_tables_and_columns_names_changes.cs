using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paskaita_8_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class tables_and_columns_names_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Books_BooksBookId",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Categories_CategoriesCategoryId",
                table: "BookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "BookCategories");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "LibraryBooks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BookCategories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "BookCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "LibraryBooks",
                newName: "Year2");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LibraryBooks",
                newName: "Name2");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "LibraryBooks",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBooks",
                table: "LibraryBooks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_BookCategories_CategoriesCategoryId",
                table: "BookCategory",
                column: "CategoriesCategoryId",
                principalTable: "BookCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_LibraryBooks_BooksBookId",
                table: "BookCategory",
                column: "BooksBookId",
                principalTable: "LibraryBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_BookCategories_CategoriesCategoryId",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_LibraryBooks_BooksBookId",
                table: "BookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBooks",
                table: "LibraryBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.RenameTable(
                name: "LibraryBooks",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "Year2",
                table: "Books",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Name2",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Books_BooksBookId",
                table: "BookCategory",
                column: "BooksBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Categories_CategoriesCategoryId",
                table: "BookCategory",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
