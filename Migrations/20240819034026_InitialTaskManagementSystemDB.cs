using Microsoft.EntityFrameworkCore.Migrations;
//19/8

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialTaskManagementSystemDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Projects_ProjectId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Tasks_TaskId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Users_UserId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_ProjectId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_TaskId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_UserId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Attachments");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfilePicId",
                table: "Users",
                column: "ProfilePicId",
                unique: true,
                filter: "[ProfilePicId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AttachmentId",
                table: "Tasks",
                column: "AttachmentId",
                unique: true,
                filter: "[AttachmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AttachmentId",
                table: "Projects",
                column: "AttachmentId",
                unique: true,
                filter: "[AttachmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Attachments_ProfilePicId",
                table: "Users",
                column: "ProfilePicId",
                principalTable: "Attachments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Attachments_ProfilePicId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProfilePicId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AttachmentId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Attachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Attachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Attachments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_ProjectId",
                table: "Attachments",
                column: "ProjectId",
                unique: true,
                filter: "[ProjectId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_TaskId",
                table: "Attachments",
                column: "TaskId",
                unique: true,
                filter: "[TaskId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_UserId",
                table: "Attachments",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Projects_ProjectId",
                table: "Attachments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Tasks_TaskId",
                table: "Attachments",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Users_UserId",
                table: "Attachments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
