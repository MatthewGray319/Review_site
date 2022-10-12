using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Project.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "ProductId", "ReviewId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
