using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Model
{
    public class ApplicationDBContext : DbContext, IDbContext
    {
        private readonly bool isMemoryDatabase;
        public ApplicationDBContext(IConfiguration configurations, bool isMemoryDatabase = false)
        {
            this.Configs = configurations;
            this.isMemoryDatabase = isMemoryDatabase;
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Subscriber> Subscriber { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Backup> Backup { get; set; }
        public virtual DbSet<Author> Author { get; set; }

        protected IConfiguration Configs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (this.isMemoryDatabase)
            {
                return;
            }

            if (!optionsBuilder.IsConfigured && this.Configs != null)
            {
                optionsBuilder.UseMySql(string.IsNullOrEmpty(this.Configs["ConnectionStrings:DBConnection"]) ? this.Configs.GetConnectionString("DBConnection") : this.Configs["ConnectionStrings:DBConnection"]);

                // optionsBuilder.UseSecondLevelCache();
            }
            optionsBuilder
                .UseMySql("server=localhost;database=genz;user=root;password=;sslmode=none;")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
