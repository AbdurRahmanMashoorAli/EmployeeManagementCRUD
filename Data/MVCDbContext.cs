﻿using EmlpoyeeManagementCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmlpoyeeManagementCRUD.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
