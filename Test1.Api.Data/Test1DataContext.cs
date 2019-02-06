using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test1.Api.Data.Models;
using Npgsql.EntityFrameworkCore;

namespace Test1.Api.Data
{
   public  class Test1DataContext:DbContext
    {
        
        public DbSet<Country> Countries { get; set; }
        private string _connectionString;
        public Test1DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Test1DataContext()
        {
            _connectionString = "Host=10.7.0.45;Database=Test1;Username=postgres;Password=SuSE1997sunri";
        }
           
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>optionsBuilder.UseNpgsql(_connectionString);

        



    }
}
