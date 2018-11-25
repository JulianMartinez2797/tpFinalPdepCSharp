using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiratasDelCaribe;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaHumanoides
    {
        [TestMethod]
        // Testeando: "El poder de mando de un Humanoide es su poder de pelea"
        public void PoderDeMandoHumanoide()
        {
            // Arrange
            var unHumanoide = new Humanoide(100, 30);

            // Act
            var resultado = unHumanoide.poderDeMando();

            // Assert
            Assert.AreEqual(30, resultado);
        }
    }
}
