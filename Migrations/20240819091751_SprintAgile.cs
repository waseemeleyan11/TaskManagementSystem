using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SprintAgile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Sprints_SprintId",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "AgileId",
                table: "Sprints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_AgileId",
                table: "Sprints",
                column: "AgileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Agiles_AgileId",
                table: "Sprints",
                column: "AgileId",
                principalTable: "Agiles",
                principalColumn: "projectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Sprints_SprintId",
                table: "Tasks",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Agiles_AgileId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Sprints_SprintId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Sprints_AgileId",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "AgileId",
                table: "Sprints");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Sprints_SprintId",
                table: "Tasks",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
