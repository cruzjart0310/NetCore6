using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using DataAccess.Entities;

namespace Talent.Backend.DataAccessEF
{
    public class Context : IdentityDbContext<User, IdentityRole, string,
        IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {

        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> ApplicationUsers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamUser> TeamUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.LogTo(Console.WriteLine);
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(@"Server=LAPTOP-NOTLMK8N;Database=NetCore6;Integrated Security=True");
            }

            base.OnConfiguring(optionBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(b =>
            {
                b.HasMany(e => e.Teams)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Team>(b =>
            {
                b.HasMany(e => e.Users)
                .WithOne(e => e.TeamAssigned)
                .HasForeignKey(e => e.TeamAssignedId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(builder);
        }
    }
}

