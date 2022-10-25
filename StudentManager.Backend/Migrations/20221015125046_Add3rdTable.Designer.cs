﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManager.Backend.Contexts;

#nullable disable

namespace StudentManager.Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221015125046_Add3rdTable")]
    partial class Add3rdTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentManager.Backend.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.StudentsSkills", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("StudentsSkills");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.StudentsSkills", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.Skill", "Skill")
                        .WithMany("StudentsSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManager.Backend.Entities.Student", "Student")
                        .WithMany("StudentsSkills")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Skill", b =>
                {
                    b.Navigation("StudentsSkills");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Student", b =>
                {
                    b.Navigation("StudentsSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
