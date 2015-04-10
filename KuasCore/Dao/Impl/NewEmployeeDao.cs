using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class NewEployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employees1 = new Employee();
            employees1.Id = "JUJU";
            employees1.Name = "啾啾";
            employees1.Age = 28;
            employees.Add(employees1);

        

            Employee employees2 = new Employee();
            employees2.Id = "Jack";
            employees2.Name = "杰克仔";
            employees2.Age = 20;
            employees.Add(employees2);

            return employees;
        }
        public Employee GetEmployeeById(string id)
        {
            Employee employees2 = new Employee();
            employees2.Id = "Jack";
            employees2.Name = "杰克仔";
            employees2.Age = 20;
         
            return employees2;
        }
    }
}
