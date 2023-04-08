using InterviewLearning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<Restaunt> restaunts { get; set; }

        public DbSet<Menu> menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Restaunt>()
           .HasMany(r => r.Menu)
           .WithOne(m => m.Restaunt)
           .HasForeignKey(m => m.RestauntId)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Restaunts)
                .WithOne(r => r.user)
                .HasForeignKey(r => r.userId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>().HasData(
        //    new User()
        //    {
        //        UserId= new Guid(),
        //        UserName="SoniSingh",
        //        Email="soni@abhi.com",
        //        Password="monusoni",
        //         UserType=  UserType.Customer
        //    });
        //}
    }
}
