using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcTest.Migrations
{
    /// <inheritdoc />
    public partial class NguyenQuocAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguyenQuocAnh",
                columns: table => new
                {
                    MaSv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sdt = table.Column<int>(type: "int", nullable: false),
                    maso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenQuocAnh", x => x.MaSv);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguyenQuocAnh");
        }
    }
}
