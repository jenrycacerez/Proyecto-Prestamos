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
            persona.Nombres = "Jenry";
            persona.Telefono = "829-638-2495";
            persona.Cedula = "402-2655042-0";
            persona.Direccion = "calle 8 # 179";
            persona.FechaNacimiento = DateTime.Now;
            
            paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);
        }

        
        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = PersonasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Personas persona = PersonasBLL.Buscar(1);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Personas> lista = PersonasBLL.GetList();
            Assert.IsNotNull(lista);
        }

       

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PersonasBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}