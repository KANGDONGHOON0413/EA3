using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Note.DAL.DataContext
{
    class AspDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AspDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Notice> Table_Notice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Connstring"));
        }

    }
}
