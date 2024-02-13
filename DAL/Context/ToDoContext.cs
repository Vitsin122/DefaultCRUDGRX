using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DefaultCRUDGRX.DAL.Models;

namespace DefaultCRUDGRX.DAL.Context
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        public ToDoContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .ToTable("ToDos")
                .HasKey(u => u.Id);

            modelBuilder.Entity<ToDo>()
                .HasOne(u => u.Status)
                .WithOne(c => c.Todo)
                .HasForeignKey<ToDo>(u => u.Status_ID);
                
            modelBuilder.Entity<ToDo>().Property(u => u.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ToDo>().Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<ToDo>().Property(u => u.Description)
                .IsRequired();

            modelBuilder.Entity<ToDo>().HasAlternateKey(u => u.Name);


            modelBuilder.Entity<Status>()
                .ToTable("Statuses")
                .HasKey(u => u.Status_ID);

            modelBuilder.Entity<Status>().Property(u => u.Status_ID)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Status>().Property(u => u.Status_Name)
                .IsRequired();

            modelBuilder.Entity<Status>().HasAlternateKey(u => u.Status_Name);

            modelBuilder.Entity<Status>()
                .HasData( new Status { Status_ID=0,Status_Name = "Создана"},
                          new Status { Status_ID=1,Status_Name = "В работе"},
                          new Status { Status_ID=2,Status_Name = "Завершена"}
                 );
            
        }
    }
}
