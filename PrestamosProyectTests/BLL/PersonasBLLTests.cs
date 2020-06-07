using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosProyect.BLL;
using PrestamosProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosProyect.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Personas persona = new Personas();
            persona.Nombres = "Estiven Padilla Santos";
            persona.Telefono = "809-290-1234";
            persona.Cedula = "402-1234567-1";
            persona.Direccion = "Bomba de Cenovi";
            persona.FechaNacimiento = DateTime.Now;

            paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

       

        [TestMethod()]
        public void ExisteTest()
        {
            Assert.Fail();
        }

       

    }
}

