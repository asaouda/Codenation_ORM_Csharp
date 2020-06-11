using Microsoft.EntityFrameworkCore;
using System;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext, IDisposable
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Challenge> Challenges { get; set; }

        public DbSet<Acceleration> Accelerations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Submission>()
                        .ToTable("submission")
                        .HasKey(c => new { c.ChallengeId, c.UserId});
                        
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>()
                        .ToTable("candidate")
                        .HasKey(c => new { c.CompanyId, c.UserId,c.AccelerationId });

            base.OnModelCreating(modelBuilder);

        }
    }
}