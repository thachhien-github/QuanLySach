using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLySach.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sach",
                columns: new[] { "Id", "Author", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Phạm Hồng Phước", 150000m, "Lập trình C# cơ bản" },
                    { 2, "Nguyễn Hoàng Anh", 200000m, "ASP.NET Core Web API" },
                    { 3, "Trần Minh Đức", 180000m, "Entity Framework Core" },
                    { 4, "Đỗ Văn Hiếu", 220000m, "SQL Server từ A đến Z" },
                    { 5, "Võ Minh Tuấn", 120000m, "HTML, CSS, JavaScript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sach");
        }
    }
}
