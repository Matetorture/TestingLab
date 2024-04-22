using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingLab.Migrations
{
    /// <inheritdoc />
    public partial class ActiveTestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestReviewEntities_AspNetUsers_UserId",
                table: "TestReviewEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_TestReviewEntities_TestRequestEntities_Id",
                table: "TestReviewEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestReviewEntities",
                table: "TestReviewEntities");

            migrationBuilder.RenameTable(
                name: "TestReviewEntities",
                newName: "TestReviewEntity");

            migrationBuilder.RenameIndex(
                name: "IX_TestReviewEntities_UserId",
                table: "TestReviewEntity",
                newName: "IX_TestReviewEntity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestReviewEntity",
                table: "TestReviewEntity",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ActiveTestsEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JoinedToTest = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveTestsEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveTestsEntity_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActiveTestsEntity_TestRequestEntities_Id",
                        column: x => x.Id,
                        principalTable: "TestRequestEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveTestsEntity_UserId",
                table: "ActiveTestsEntity",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestReviewEntity_AspNetUsers_UserId",
                table: "TestReviewEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestReviewEntity_TestRequestEntities_Id",
                table: "TestReviewEntity",
                column: "Id",
                principalTable: "TestRequestEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestReviewEntity_AspNetUsers_UserId",
                table: "TestReviewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_TestReviewEntity_TestRequestEntities_Id",
                table: "TestReviewEntity");

            migrationBuilder.DropTable(
                name: "ActiveTestsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestReviewEntity",
                table: "TestReviewEntity");

            migrationBuilder.RenameTable(
                name: "TestReviewEntity",
                newName: "TestReviewEntities");

            migrationBuilder.RenameIndex(
                name: "IX_TestReviewEntity_UserId",
                table: "TestReviewEntities",
                newName: "IX_TestReviewEntities_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestReviewEntities",
                table: "TestReviewEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestReviewEntities_AspNetUsers_UserId",
                table: "TestReviewEntities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestReviewEntities_TestRequestEntities_Id",
                table: "TestReviewEntities",
                column: "Id",
                principalTable: "TestRequestEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
