using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Tavisca.CrudOperation;
using Training.Tavisca.CrudOperation.Controllers;
using Training.Tavisca.CrudOperation.Models;


namespace ControllerTest
{
    [TestClass]
    public class InforamtionControllerTest
    {

        EmployeeInformationController employeeInformationController;


        [TestMethod]
        public void Check_Post()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Ramcharan";
            employee.Designation = "Devops";
            employeeInformationController = new EmployeeInformationController();
            Employee postEmployee=employeeInformationController.Post(employee);
            Assert.AreEqual(postEmployee.Id, employee.Id);
            
        }
    }
}
