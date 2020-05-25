using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public MyContext() { }

        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<API.Models.Type> Types { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<BatchClass> batchClasses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Room> Rooms { get; set; }        
    }
}
