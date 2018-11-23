using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGuardarXml()
        {
            Xml<string> xml = new Xml<string>();
            string retorno;

            xml.Guardar("Prueba", "Probando el xml");
            xml.Leer("Prueba", out retorno);

            Assert.IsTrue(retorno == "Probando el xml");
        }

        [TestMethod]
        public void TestGuardarTexto()
        {
            Texto txt = new Texto();
            Queue<Patente> patentes = new Queue<Patente>();
            Queue<Patente> retorno = new Queue<Patente>();

            Patente p1 = new Patente("ASD541", Patente.Tipo.Vieja);

            patentes.Enqueue(p1);

            txt.Guardar("Prueba", patentes);
            txt.Leer("Prueba", out retorno);

            Assert.IsTrue(retorno == patentes);
        }


        [TestMethod]
        public void TestGuardarSql()
        {
            Sql sql = new Sql();
            Queue<Patente> patentes = new Queue<Patente>();
            Queue<Patente> retorno = new Queue<Patente>();

            Patente p1 = new Patente("ASD541", Patente.Tipo.Vieja);

            patentes.Enqueue(p1);

            sql.Guardar("Prueba", patentes);
            sql.Leer("Prueba", out retorno);

            Assert.IsTrue(retorno == patentes);
        }

    }
}
