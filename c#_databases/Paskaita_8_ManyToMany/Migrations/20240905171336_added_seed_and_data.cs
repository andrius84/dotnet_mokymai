using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Paskaita_8_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class added_seed_and_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, "N.K.", "Jemisin" },
                    { 4, "Brandon", "Sanderson" },
                    { 5, "Patrick", "Rothfuss" },
                    { 6, "Joe", "Abercrombie" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookName", "BookYear" },
                values: new object[,]
                {
                    { 8, "The Fifth Season", 2015 },
                    { 9, "Mistborn: The Final Empire", 2006 },
                    { 10, "The Name of the Wind", 2007 },
                    { 11, "The Way of Kings", 2010 },
                    { 12, "Red Sister", 2017 },
                    { 13, "The Blade Itself", 2009 },
                    { 14, "The Heroes", 2011 }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorsAuthorId", "BooksBookId" },
                values: new object[,]
                {
                    { 3, 8 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 10 },
                    { 5, 12 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorsAuthorId", "BooksBookId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
