using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace Ejercicio45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodoEstatico()
        {
            try
            {
                MiClaseErrores.MetodoExcepcion();
                Assert.Fail();         
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException)); 
            }
        }

        [TestMethod]
        public void TestConstructorExcepcion1()
        {
            try
            {
                MiClaseErrores objeto = new MiClaseErrores();
                Assert.Fail();               
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException)); 
            }
        }

        [TestMethod]
        public void TestConstructorExcepcion2()
        {
            try
            {
                MiClaseErrores objeto = new MiClaseErrores(0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(UnaExcepcion));
                Assert.IsInstanceOfType(e.InnerException, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void MetodoInstanciaOtraClase()
        {
            OtraClase objeto = new OtraClase();
            try
            {
                objeto.MiMetodoInstancia();
                Assert.Fail();              
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(MiExcepcion));
                Assert.IsInstanceOfType(e.InnerException, typeof(UnaExcepcion));
                Assert.IsInstanceOfType(e.InnerException.InnerException, typeof(DivideByZeroException));
            }
        }
    }
}
