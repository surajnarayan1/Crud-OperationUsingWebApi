﻿using System;
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

        public Employee GetProduct(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }



    }





}
