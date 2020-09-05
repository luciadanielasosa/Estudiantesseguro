using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {//Arange
            StudentsController studentsController = new StudentsController();
            //Act
            var ListaEstudiante = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
