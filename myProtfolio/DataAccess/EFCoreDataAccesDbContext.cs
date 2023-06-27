using Microsoft.EntityFrameworkCore;
using myProtfolio.Models;
using System;


namespace myProtfolio.DataAccess
{
    public class EFCoreDataAccesDbContext : DbContext
    {
        public DbSet<Project> projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PortFolio;Trusted_connection=yes;;MultipleActiveResultSets=true;");
        }
    }
}
