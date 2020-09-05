using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiSeccureStudent.Models;

namespace UnitTestEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {//arange
            StudentsController studentsController = new StudentsController();


            //act
            var ListaEstudiante = studentsController.GetStudents();
            //assert
            Assert.IsNotNull(ListaEstudiante);

        }
    }
}
