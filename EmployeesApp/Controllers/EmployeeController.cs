

using EmployeesApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace EmployeesApp.Controllers
{
    public class EmployeeController : Controller
    {

        HrDatabaseContext Context = new HrDatabaseContext();
        

        public IActionResult Index()
        {
            List<Employee> employeesList = Context.Employees.ToList();

            return View(employeesList);
        }

        public IActionResult Create()
        {
            return View();
        }

       

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var employee = Context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
                return View(employee);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var employee = Context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }else
            return View(employee);
        }



        public IActionResult Delete(int id)
        {
            var employee = Context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            Context.Employees.Remove(employee);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                if (emp.EmployeesId == 0)
                {
                    Context.Employees.Add(emp);
                    Context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var employee = Context.Employees.Find(emp.EmployeesId);
                    if (employee == null)
                    {
                        return NotFound(emp.EmployeesId);
                    }else
                    { 
                        employee.EmployeeNumber = emp.EmployeeNumber ;
                        employee.EmployeeName = emp.EmployeeName ;
                        employee.DOB = emp.DOB ;
                        employee.HiringDate = emp.HiringDate ;
                        employee.NetSalary = emp.NetSalary ;
                        employee.GrossSalary = emp.GrossSalary ;
                        Context.SaveChanges();
                        return RedirectToAction(nameof(Index));
                    }

                }


            }
            else
                return View();
              
            

           


            
        }


    }

   
}
