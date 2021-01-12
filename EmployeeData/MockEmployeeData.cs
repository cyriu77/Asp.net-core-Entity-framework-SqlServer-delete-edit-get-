
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee One"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee Two"
            },
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public List<Employee> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id); 
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
