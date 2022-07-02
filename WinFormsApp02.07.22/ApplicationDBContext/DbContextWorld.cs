using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WinFormsApp02._07._22.Entities;

namespace WinFormsApp02._07._22.ApplicationDBContext
{
    public class DbContextWorld:DbContext
    {
        public List<Country> GetCountries { get; set; } 
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;

        public string connectionString;
        public DbContextWorld(string connectionString)
        {
            GetCountries = new List<Country>();
            this.connectionString = connectionString;   // получаем извне строку подключения
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

    }
}
