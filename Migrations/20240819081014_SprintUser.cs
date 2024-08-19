using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SprintUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Sprints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_UserId",
                table: "Sprints",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Users_UserId",
                table: "Sprints",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Users_UserId",
                table: "Sprints");

            migrationBuilder.DropIndex(
                name: "IX_Sprints_UserId",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sprints");
        }
    }
}
