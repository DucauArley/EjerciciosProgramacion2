using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio41;

namespace Ejercicio44
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCentralitaLlamadas()
        {
            Centralita cen = new Centralita("Roberto");

            Assert.IsNotNull(cen.Llamadas);
        }

        [TestMethod]
        public void TestCentralitaExcepcionLocal()
        {
            Local l1 = new Local("Lugano", 20, "Mataderos", 34);
            Local l2 = new Local("Lugano", 43, "Mataderos", 27);
            Centralita cen = new Centralita("Roberto");

            try
            {
                cen = cen + l1;
                cen = cen + l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaExcepcion));
            }

        }

        [TestMethod]
        public void TestCentralitaExcepcionProvincial()
        {
            Provincial p1 = new Provincial("Mendoza", Provincial.Franja.Franja_2, 120, "Cordoba");
            Provincial p2 = new Provincial("Mendoza", Provincial.Franja.Franja_1, 345, "Cordoba");
            Centralita cen = new Centralita("Roberto");

            try
            {
                cen = cen + p1;
                cen = cen + p2;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaExcepcion));
            }

        }

        [TestMethod]
        public void TestCentralitaExcepcionLocalProvincial()
        {
            Provincial p1 = new Provincial("Cordoba", Provincial.Franja.Franja_3, 554,"Mendoza");
            Provincial p2 = new Provincial("Cordoba", Provincial.Franja.Franja_3, 152, "Mendoza");
            Local l1 = new Local("Cordoba", 43, "Mendoza", 52);
            Local l2 = new Local("Cordoba", 12, "Mendoza", 12);

            Assert.IsTrue(p1 == p2);
            Assert.IsFalse(p1 == l1);
            Assert.IsFalse(p1 == l2);
            Assert.IsFalse(p2 == l1);
            Assert.IsFalse(p2 == l2);
            Assert.IsTrue(l1 == l2);

        }
        
    }
}
