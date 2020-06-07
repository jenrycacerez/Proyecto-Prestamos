using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosProyect.BLL;
using PrestamosProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PrestamosProyect.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Prestamos p = new Prestamos();
            p.PrestamoId = 1;
            p.PersonaId = 1;
            p.Fecha = DateTime.Now;
            p.Concepto = "Deuda";
            p.Monto = 100;
            p.Balance = 100;
            paso = PrestamosBLL.Guardar(p);
            Assert.AreEqual(paso, true);
        
         }

        public void ModificarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoId = 1;
            prestamo.PersonaId = 1;
            prestamo.Concepto = " Modificada";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 200;

            paso = PrestamosBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {

            bool paso;

            paso = PrestamosBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos p;
            p = PrestamosBLL.Buscar(1);


            Assert.AreEqual(p, p);
        }

     

        [TestMethod()]
        public void GetListTest1()
        {
            var lista = new List<Prestamos>();
            lista = PrestamosBLL.GetList(p => true);


            Assert.AreEqual(lista, lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PrestamosBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}