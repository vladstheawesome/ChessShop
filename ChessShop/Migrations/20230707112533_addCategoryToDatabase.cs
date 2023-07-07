using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessShop.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryid = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    displayorder = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<decimal>(type: "numeric", nullable: false),
                    lastuser = table.Column<Guid>(type: "uuid", nullable: true),
                    lastusername = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    createdtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modifiedtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    inuse = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
