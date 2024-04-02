using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    internal class CompaniesDatabase : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public CompaniesDatabase() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=Comp.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company() {Id = 1, isValid = true, name = "Przykladowa firma", address = "Adres przykladowej firmy", vatNumber = "123456789" }) ;
        }
    }
}
