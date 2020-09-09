using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess
{
    public class EmployeeContext : DbContext
    {
        /// <summary>
        /// Context class with DbContext implemented
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog =EmployeeDB;Integrated Security = True;");
        }
        //Employee Table made by Dbset
        public DbSet<Employee> Employee { get; set; }
        //Department Table made by Dbset
        public DbSet<Department> Department { get; set; }
    }
}
