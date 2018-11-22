using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void TestErrorArchivoException()
        {
            Votacion votacion = null;
            SerializarXml<Votacion> ser = new SerializarXml<Votacion>();

            ser.Guardar("Juancarlos.xml", votacion);
        }

        [TestMethod]
        public void TestInvocacionDelEvento()
        {
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();
            senadores.Add("1", Votacion.EVoto.Afirmativo);
            senadores.Add("2", Votacion.EVoto.Abstencion);
            senadores.Add("3", Votacion.EVoto.Negativo);
            senadores.Add("4", Votacion.EVoto.Afirmativo);

            Votacion votacion = new Votacion("Ley para los Juan Carlos", senadores);
            votacion.Simular();

            Assert.IsTrue(votacion.ContadorAfirmativo == 2);
            Assert.IsTrue(votacion.ContadorAbstencion == 1);
            Assert.IsTrue(votacion.ContadorNegativo == 1);
        }


    }
}
