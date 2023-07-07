using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FIRST.Models
{
    internal class StdContext:DbContext
    {
        public DbSet<Std> stds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-KR3SF32I\\SQLEXPRESS;database=School;integrated security=true;trustservercertificate=true;");
        }

    }
}
