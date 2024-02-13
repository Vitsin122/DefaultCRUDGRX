﻿// <auto-generated />
using DefaultCRUDGRX.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DefaultCRUDGRX.DAL.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20240213045620_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DefaultCRUDGRX.DAL.Models.Status", b =>
                {
                    b.Property<int>("Status_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Status_ID");

                    b.HasAlternateKey("Status_Name");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Status_ID = 1,
                            Status_Name = "Создана"
                        },
                        new
                        {
                            Status_ID = 2,
                            Status_Name = "В работе"
                        },
                        new
                        {
                            Status_ID = 3,
                            Status_Name = "Завершена"
                        });
                });

            modelBuilder.Entity("DefaultCRUDGRX.DAL.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasIndex("Status_ID")
                        .IsUnique();

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("DefaultCRUDGRX.DAL.Models.ToDo", b =>
                {
                    b.HasOne("DefaultCRUDGRX.DAL.Models.Status", "Status")
                        .WithOne("Todo")
                        .HasForeignKey("DefaultCRUDGRX.DAL.Models.ToDo", "Status_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DefaultCRUDGRX.DAL.Models.Status", b =>
                {
                    b.Navigation("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}