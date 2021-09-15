using System;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FlamingSoftHR.Server.Models
{
    public class FlamingSoftHRContext : DbContext
    {

        public FlamingSoftHRContext(DbContextOptions<FlamingSoftHRContext> options)
            : base(options)
        {
        }

        /*public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<DeviceCode> DeviceCodes { get; set; }
        public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }*/

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<LoggedTime> LoggedTime { get; set; }
        public virtual DbSet<LoggedTimeType> LoggedTimeType { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Department Table
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 2, Name = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 3, Name = "Payroll" });
        }*/


    }
}
