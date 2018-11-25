using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PiratasDelCaribe;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaPirata
    {
        Guerrero unGuerrero;
        Navegador unNavegador;
        Cocinero unCocinero;
        JackSparrow jackSparrow;

        [TestCleanup]
        public void testClean()
        {
            unGuerrero = null;
            unNavegador = null;
            unCocinero = null;
            jackSparrow = null;
        }

        [TestInitialize]
        public void testInit()
        {
            unGuerrero = new Guerrero(150, 25, 5);
            unNavegador = new Navegador(50, 10);
            List<String> ingredientes = new List<String>();
            ingredientes.Add("tomate");
            ingredientes.Add("arroz");
            ingredientes.Add("carne");
            unCocinero = new Cocinero(80, 12, ingredientes);
            jackSparrow = JackSparrow.obtenerInstancia();
        }

        [TestMethod]
        // Testeando: "El poder de mando de un Guerrero es su poder de pelea * su vitalidad"
        public void PoderDeMandoGuerrero()
        {
            // Arrange
            // Act
            var resultado = unGuerrero.poderDeMando();

            // Assert
            Assert.AreEqual(125, resultado);
        }
        [TestMethod]
        // Testeando: "El poder de mando de un Navegador es su inteligencia al cuadrado"
        public void PoderDeMandoNavegador()
        {
            // Arrange
            // Act
            var resultado = unNavegador.poderDeMando();

            // Assert
            Assert.AreEqual(100, resultado);
        }
        [TestMethod]
        // Testeando: "El poder de mando de un Cocinero es su moral por la cantidad de ingredientes que posee"

        public void PoderDeMandoCocinero()
        {
            // Arrange
            // Act
            var resultado = unCocinero.poderDeMando();

            // Assert
            Assert.AreEqual(36, resultado);
        }
        [TestMethod]
        // Testeando: "El poder de mando de jackSparrow es la sumatoria de sus atributos numericos"
        public void PoderDeMandoJackSparrow()
        {
            // Arrange
            // Act
            var resultado = jackSparrow.poderDeMando();   
        
            // Assert
            Assert.AreEqual(1000, resultado);
        }
        [TestMethod]
        // Testeando: "Cuando JackSparrow bebe ron con un pirata, su energia aumenta en 100"
        public void EnergiaDeJackDespuesDeBeberRonConUnTripulante()
        {
            // Arrange
            // Act
            jackSparrow.beberRonCon(unGuerrero);
            var resultado = jackSparrow.energia;
      
            // Assert
            Assert.AreEqual(600, resultado);
        }
        [TestMethod]
        // Testeando: "Cuando un pirata bebe ron con jack, su energia disminuye en 50"
        public void EnergiaDePirataDespuesDeBeberRonConUnTripulante()
        {
            // Arrange
            // Act
            jackSparrow.beberRonCon(unGuerrero);
            var resultado = unGuerrero.energia;

            // Assert
            Assert.AreEqual(100, resultado);
        }
        [TestMethod]
        // Testeando: "Cuando un cocinero bebe ron con jack pierde un ingrediente al azar"
        public void CocineroDespuesDeBeberRonConJack()
        {
            // Arrange
            // Act
            jackSparrow.beberRonCon(unCocinero);
            var resultado = unCocinero.Ingredientes.Count();
            // Assert
            Assert.AreEqual(2, resultado);
        }
        [TestMethod]
        // Testeando: "Un Pirata con un poder de mando mayor a 100 es fuerte"
        public void UnPirataConMasDe100DePoderDeMandoEsFuerte()
        {
            // Arrange
            // Act
            var resultado = unGuerrero.esFuerte();
            // Assert
            Assert.IsTrue(resultado);
        }
    }
}
