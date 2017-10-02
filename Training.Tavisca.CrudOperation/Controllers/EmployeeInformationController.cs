using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Training.Tavisca.CrudOperation.Models;

namespace Training.Tavisca.CrudOperation.Controllers
{
    public class EmployeeInformationController : ApiController
    {
        IRepository repository = new EmployeeRepository();
     
        //Return the list of EmployeeInformation
        public List<Employee> GetAll()
        {
            return repository.GetAll();
        }
        //Return the The particular EmployeeInformation

        public Employee Get(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public Employee Ppostt(Employee newEmployeeinformation)
        {
           Employee item = repository.Add(newEmployeeinformation);
            return item;
        }
        public void PutEmployee(int id, Employee employeeInformation)
        {
            employeeInformation.Id = id;
            if (!repository.Update(employeeInformation))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        public void DeleteProduct(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }

    }

}
