using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<NormalUser> Teachers{ get; set; }

        public DbSet<Student> Students { get; set; }

        


        public readonly string path = @"C:\Users\User\Documents\UoR\Semester 3\GUI Programming\New folder\GroupProject\GroupProject\group.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlite($"Data Source = {path}");
        }
    }
    
}

