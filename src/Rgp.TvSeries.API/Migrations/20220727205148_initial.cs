using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rgp.TvSeries.API.Migrations
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
                values: new object[] { "082c5128-33a0-4373-8eda-ecb329947fa6", "The survivors of a plane crash are forced to work together in order to survive on a seemingly deserted tropical island.", "Lost" });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Summary", "Title" },
                values: new object[] { "17a9efe3-1b70-48dc-af3a-55615f54bca6", "When a young boy disappears, his mother, a police chief and his friends must confront terrifying supernatural forces in order to get him back.", "Stranger Things" });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Summary", "Title" },
                values: new object[] { "c74503d1-b354-4483-97df-a071b24c320a", "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "Breaking Bad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TvSeries");
        }
    }
}
