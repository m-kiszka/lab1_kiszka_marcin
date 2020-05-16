using Lab1_Kiszka.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Kiszka.Context
{
    public class PersonContext : DbContext
    {

        private readonly string _connectionString = "Server=tcp:mkiszka.database.windows.net,1433;Initial Catalog=mkiszka_cdv;Persist Security Info=False;User ID=mkiszka;Password=Test123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
