using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ApiSeccureStudent.Controllers;




namespace Utstudentseccure.text
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arange
            StudentsController studentsController = new StudentsController();

            //Act
            var ListaEstudiante = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
