using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddWaterfallAgile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_WaterfallprojectId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExpectedEndTime",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TimeForEageSprint",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "Agiles",
                columns: table => new
                {
                    projectId = table.Column<int>(type: "int", nullable: false),
                    TimeForEageSprint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agiles", x => x.projectId);
                    table.ForeignKey(
                        name: "FK_Agiles_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waterfalls",
                columns: table => new
                {
                    projectId = table.Column<int>(type: "int", nullable: false),
                    ExpectedEndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waterfalls", x => x.projectId);
                    table.ForeignKey(
                        name: "FK_Waterfalls_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Waterfalls_WaterfallprojectId",
                table: "Tasks",
                column: "WaterfallprojectId",
                principalTable: "Waterfalls",
                principalColumn: "projectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Waterfalls_WaterfallprojectId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Agiles");

            migrationBuilder.DropTable(
                name: "Waterfalls");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Projects",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedEndTime",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeForEageSprint",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_WaterfallprojectId",
                table: "Tasks",
                column: "WaterfallprojectId",
                principalTable: "Projects",
                principalColumn: "projectId");
        }
    }
}
