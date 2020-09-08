﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200908140907_AddedNewColumnInUserTable")]
    partial class AddedNewColumnInUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskManagerAPI.Models.Tasks", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isCompleted")
                        .HasColumnType("bit");

                    b.HasKey("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TaskManagerAPI.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TaskManagerAPI.Models.Tasks", b =>
                {
                    b.HasOne("TaskManagerAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
