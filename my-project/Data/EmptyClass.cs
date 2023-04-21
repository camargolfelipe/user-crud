using System;
using my_project.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace my_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

}

