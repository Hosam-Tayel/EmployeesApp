using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Models
{
    public class HrDatabaseContext : DbContext //connecting oint between app and database
    {
        //public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EmployeeDB;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                EmployeesId = 1,
                EmployeeNumber = "1001",
                EmployeeName = "ahmed",
                DOB = DateTime.Now,
                HiringDate = DateTime.Now,
                GrossSalary = 8000,
                NetSalary = 7000
            },
            new Employee()
            {
                EmployeesId = 2,
                EmployeeNumber = "1002",
                EmployeeName = "hassan",
                DOB = DateTime.Now,
                HiringDate = DateTime.Now,
                GrossSalary = 9000,
                NetSalary = 1000
            },
            new Employee()
            {
                EmployeesId = 3,
                EmployeeNumber = "1003",
                EmployeeName = "ibrahim",
                DOB = DateTime.Now,
                HiringDate = DateTime.Now,
                GrossSalary = 9000,
                NetSalary = 1000
            }, new Employee()
            {
                EmployeesId = 4,
                EmployeeNumber = "1004",
                EmployeeName = "yasser",
                DOB = DateTime.Now,
                HiringDate = DateTime.Now,
                GrossSalary = 9000,
                NetSalary = 1000
            }


           );

           
           



        }
    }
}
