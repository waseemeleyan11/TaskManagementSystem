﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagementSystem.Data;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("AddedById")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("AddedById");

                    b.HasIndex("TaskId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<int?>("AddedAttachmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpectedDateToStart")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Status")
                        .HasMaxLength(128)
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("AddedAttachmentId")
                        .IsUnique();

                    b.HasIndex("CreatedById");

                    b.ToTable("Projects");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.ProjectUser", b =>
                {
                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("DeveloperId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Sprint", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AgileId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("id");

                    b.HasIndex("AgileId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UserId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddedAttachmentId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionAttachment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SprintId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("WaterfallId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddedAttachmentId")
                        .IsUnique()
                        .HasFilter("[AddedAttachmentId] IS NOT NULL");

                    b.HasIndex("CreatedById");

                    b.HasIndex("SprintId");

                    b.HasIndex("UserId");

                    b.HasIndex("WaterfallId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.UserTask", b =>
                {
                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("DeveloperId", "TaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("TaskManagementSystem.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId")
                        .IsUnique()
                        .HasFilter("[AttachmentId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Agile", b =>
                {
                    b.HasBaseType("TaskManagementSystem.Data.Models.Project");

                    b.Property<int>("TimeForEageSprint")
                        .HasColumnType("int");

                    b.ToTable("AgileProjects", (string)null);
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.HasBaseType("TaskManagementSystem.Data.Models.Project");

                    b.Property<DateTime>("ExpectedEndTime")
                        .HasColumnType("datetime2");

                    b.ToTable("WaterfallProjects", (string)null);
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Comment", b =>
                {
                    b.HasOne("TaskManagementSystem.User", "AddedBy")
                        .WithMany("Comments")
                        .HasForeignKey("AddedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.Task", "Task")
                        .WithMany("addedComments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AddedBy");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "AddedAttachment")
                        .WithOne("Project")
                        .HasForeignKey("TaskManagementSystem.Data.Models.Project", "AddedAttachmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.User", "CreatedBy")
                        .WithMany("Projects")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddedAttachment");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.ProjectUser", b =>
                {
                    b.HasOne("TaskManagementSystem.User", "Developer")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Sprint", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Agile", "Agile")
                        .WithMany("Sprints")
                        .HasForeignKey("AgileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.User", "CreatedBy")
                        .WithMany("CreatedSprints")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.User", null)
                        .WithMany("Sprints")
                        .HasForeignKey("UserId");

                    b.Navigation("Agile");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Task", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "AddedAttachment")
                        .WithOne("Task")
                        .HasForeignKey("TaskManagementSystem.Data.Models.Task", "AddedAttachmentId");

                    b.HasOne("TaskManagementSystem.User", "CreatedBy")
                        .WithMany("CreatedTasks")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.Sprint", "Sprint")
                        .WithMany("Tasks")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TaskManagementSystem.User", null)
                        .WithMany("Tasks")
                        .HasForeignKey("UserId");

                    b.HasOne("TaskManagementSystem.Data.Models.Waterfall", "Waterfall")
                        .WithMany("Tasks")
                        .HasForeignKey("WaterfallId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AddedAttachment");

                    b.Navigation("CreatedBy");

                    b.Navigation("Sprint");

                    b.Navigation("Waterfall");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.UserTask", b =>
                {
                    b.HasOne("TaskManagementSystem.User", "Developer")
                        .WithMany("UserTasks")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.Models.Task", "Task")
                        .WithMany("UserTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManagementSystem.User", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Attachment", "Attachment")
                        .WithOne("AddedBy")
                        .HasForeignKey("TaskManagementSystem.User", "AttachmentId");

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Agile", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("TaskManagementSystem.Data.Models.Agile", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("TaskManagementSystem.Data.Models.Waterfall", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Attachment", b =>
                {
                    b.Navigation("AddedBy")
                        .IsRequired();

                    b.Navigation("Project")
                        .IsRequired();

                    b.Navigation("Task")
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Project", b =>
                {
                    b.Navigation("ProjectUsers");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Sprint", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Task", b =>
                {
                    b.Navigation("UserTasks");

                    b.Navigation("addedComments");
                });

            modelBuilder.Entity("TaskManagementSystem.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CreatedSprints");

                    b.Navigation("CreatedTasks");

                    b.Navigation("ProjectUsers");

                    b.Navigation("Projects");

                    b.Navigation("Sprints");

                    b.Navigation("Tasks");

                    b.Navigation("UserTasks");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Agile", b =>
                {
                    b.Navigation("Sprints");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.Models.Waterfall", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
