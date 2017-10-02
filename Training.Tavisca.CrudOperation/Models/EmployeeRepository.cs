using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Tavisca.CrudOperation.Models
{
    public class EmployeeRepository : IRepository
    {

        private List<Employee> employeeList;
        
        public EmployeeRepository()
        {
             employeeList = new List<Employee>();
             Add(new Employee { Id = 1, Name = "SurajNarayan", Designation = "SoftwareTrainee" });
             Add(new Employee { Id = 002, Name = "Divas Agarwal", Designation = "Senior Architect" });
             Add(new Employee { Id = 003, Name = "Apandey", Designation = "Product Incharge" });
        }
      

        public List<Employee> GetAll()
        {
            return employeeList;
        }

        public Employee Get(int id)
        {
           foreach(Employee ee in employeeList)
           {
               if(ee.Id==id)
               {
                   return ee;
               }
           }


           return null;
        }

        public Employee Add(Employee EmployeeInformation)
        {
           employeeList.Add(EmployeeInformation);
           return EmployeeInformation;
        }

        public void Remove(int employeeId)
        {

            foreach (Employee ee in employeeList)
            {
                if (ee.Id == employeeId)
                {
                    employeeList.Remove(ee);
                    return;
                }
            }
        }

        public bool Update(Employee employeeInformation)
        {
            int index = employeeList.FindIndex(p => p.Id == employeeInformation.Id);
            if (index == -1)
            {
                return false;
            }
            employeeList.RemoveAt(index);
            employeeList.Add(employeeInformation);
            return true;
        }
    }
}