using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FinalProject
{
    class UserContext : DbContext
    {
        public UserContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                Console.WriteLine("Database already exists." +
                    " No additional migration have to be applied.");
            }
        }

        public DbSet<User> utilizatori{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=utilizatori.db");
        }

    }
}
