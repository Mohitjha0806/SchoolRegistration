﻿using Microsoft.EntityFrameworkCore;
using SchoolRegistration.Entities.Model;

namespace SchoolRegistration.Data.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<SchoolBasicInformations> SchoolBasicInformations { get; set; }
        public DbSet<SchoolBasicInformationStudent> SchoolBasicInformationStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OKN4EUA\\SQLEXPRESS;Database=StudentRegistration_Db;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
