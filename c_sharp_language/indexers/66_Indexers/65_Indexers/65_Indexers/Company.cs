using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _65_Indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee { EmployeeId = 1, Name = "Mike", Gender = "Male"});
            listEmployees.Add(new Employee { EmployeeId = 2, Name = "Jinna", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 3, Name = "Jhone", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 4, Name = "Kura", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 5, Name = "Sana", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 6, Name = "Dilki", Gender = "Female" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee emp in listEmployees)
                {
                    if (emp.Gender == Gender)
                    {
                        emp.Gender = value;
                    }
                }
            }
            
        }
      
    }
}