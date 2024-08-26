using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class wes14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUsers_Users_UserId",
                table: "ProjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Users_UserId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AttachmentId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserTasks",
                newName: "DeveloperId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tasks",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "AttachmentId",
                table: "Tasks",
                newName: "AddedAttachmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                newName: "IX_Tasks_CreatedById");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Sprints",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Sprints_UserId",
                table: "Sprints",
                newName: "IX_Sprints_CreatedById");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ProjectUsers",
                newName: "DeveloperId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Projects",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "AttachmentId",
                table: "Projects",
                newName: "AddedAttachmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                newName: "IX_Projects_CreatedById");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "AddedById");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                newName: "IX_Comments_AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AddedAttachmentId",
                table: "Tasks",
                column: "AddedAttachmentId",
                unique: true,
                filter: "[AddedAttachmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AddedAttachmentId",
                table: "Projects",
                column: "AddedAttachmentId",
                unique: true,
                filter: "[AddedAttachmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AddedById",
                table: "Comments",
                column: "AddedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Attachments_AddedAttachmentId",
                table: "Projects",
                column: "AddedAttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_CreatedById",
                table: "Projects",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUsers_Users_DeveloperId",
                table: "ProjectUsers",
                column: "DeveloperId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Users_CreatedById",
                table: "Sprints",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Attachments_AddedAttachmentId",
                table: "Tasks",
                column: "AddedAttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_CreatedById",
                table: "Tasks",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Users_DeveloperId",
                table: "UserTasks",
                column: "DeveloperId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AddedById",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Attachments_AddedAttachmentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_CreatedById",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUsers_Users_DeveloperId",
                table: "ProjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Users_CreatedById",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Attachments_AddedAttachmentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_CreatedById",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Users_DeveloperId",
                table: "UserTasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AddedAttachmentId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AddedAttachmentId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DeveloperId",
                table: "UserTasks",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Tasks",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AddedAttachmentId",
                table: "Tasks",
                newName: "AttachmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_CreatedById",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Sprints",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sprints_CreatedById",
                table: "Sprints",
                newName: "IX_Sprints_UserId");

            migrationBuilder.RenameColumn(
                name: "DeveloperId",
                table: "ProjectUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Projects",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AddedAttachmentId",
                table: "Projects",
                newName: "AttachmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CreatedById",
                table: "Projects",
                newName: "IX_Projects_UserId");

            migrationBuilder.RenameColumn(
                name: "AddedById",
                table: "Comments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AddedById",
                table: "Comments",
                newName: "IX_Comments_UserId");

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
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUsers_Users_UserId",
                table: "ProjectUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Users_UserId",
                table: "Sprints",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
