using CodeMaze.Entities.Configuracion;
using CodeMaze.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaze.Entities
{
    public class RepositoryContext : DbContext {
        public RepositoryContext(DbContextOptions options) 
            : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration()); 
        }
        public DbSet<Company> Companies { get; set; } 
        public DbSet<Employee> Employees { get; set; } }
}
