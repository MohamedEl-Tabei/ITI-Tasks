using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_2.Migrations
{
    /// <inheritdoc />
    public partial class Migration06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_TopicTop_Id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicTop_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TopicTop_Id",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Topic_Id",
                table: "Courses",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_Topic_Id",
                table: "Courses",
                column: "Topic_Id",
                principalTable: "Topic",
                principalColumn: "Top_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_Topic_Id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Topic_Id",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "TopicTop_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicTop_Id",
                table: "Courses",
                column: "TopicTop_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_TopicTop_Id",
                table: "Courses",
                column: "TopicTop_Id",
                principalTable: "Topic",
                principalColumn: "Top_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
