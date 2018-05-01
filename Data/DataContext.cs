
using System;
using System.Linq;
using System.Reflection;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using DatingApp.API.Data.EntityConfig;


namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Interface that all of our Entity maps implement
            
            modelBuilder.ApplyConfiguration(new ValueMap());

       

            
        }

    }
}