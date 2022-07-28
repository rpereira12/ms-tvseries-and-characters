using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rgp.TvSeries.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TvSeries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvSeries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Summary", "Title" },
                values: new object[] { "5c095b53-8c7d-4d22-9ecc-65f3a50ac216", "The survivors of a plane crash are forced to work together in order to survive on a seemingly deserted tropical island.", "Lost" });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Summary", "Title" },
                values: new object[] { "b359f834-4a89-4d21-be97-fe6577708472", "When a young boy disappears, his mother, a police chief and his friends must confront terrifying supernatural forces in order to get him back.", "Stranger Things" });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Summary", "Title" },
                values: new object[] { "d641c48b-eea7-4a5e-900f-3f8677dd76f9", "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "Breaking Bad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TvSeries");
        }
    }
}
