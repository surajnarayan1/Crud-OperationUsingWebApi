using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.CrudOperation.Models
{
    interface IRepository
    {


        List<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee  EmployeeInformation);
        void Remove(int employeeId);
        bool Update(Employee employeeInformation);



    }
}
