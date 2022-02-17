using System;
using FormulaOneFanPage.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaOneFanPage.Data {
    public class MainContext : DbContext {
        public MainContext(DbContextOptions<MainContext> options) {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Driver>().ToTable("Driver");
            modelBuilder.Entity<Team>().ToTable("Team");
        }
    }
}
