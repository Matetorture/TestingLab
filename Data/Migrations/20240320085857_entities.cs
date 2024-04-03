using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingLab.Data.Migrations
{
    /// <inheritdoc />
    public partial class entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestReviewEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestRequestEntityId = table.Column<int>(type: "int", nullable: true),
                    UserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReviewEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestReviewEntities_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TestReviewEntities_TestRequestEntities_TestRequestEntityId",
                        column: x => x.TestRequestEntityId,
                        principalTable: "TestRequestEntities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestReviewEntities_TestRequestEntityId",
                table: "TestReviewEntities",
                column: "TestRequestEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_TestReviewEntities_UserEntityId",
                table: "TestReviewEntities",
                column: "UserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestReviewEntities");
        }
    }
}
