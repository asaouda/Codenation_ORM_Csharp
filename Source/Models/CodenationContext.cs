using Microsoft.EntityFrameworkCore;
using System;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext, IDisposable
    {
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
            modelBuilder.Entity<Company>()
                        .ToTable("company");
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>()
                        .ToTable("user");
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Challenge>()
                        .ToTable("challenge");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Acceleration>()
                        .ToTable("acceleration")
                        .HasOne(p => p.Challenge)
                        .WithMany(b => b.Accelerations);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Submission>()
                        .ToTable("submission")
                        .HasKey(x => new { x.User_Id, x.Challenge_Id});
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>()
                        .ToTable("candidate")
                        .HasKey(x => new { x.User_Id, x.Acceleration_Id, x.Company_Id }); 
            
            base.OnModelCreating(modelBuilder);

        }
    }
}