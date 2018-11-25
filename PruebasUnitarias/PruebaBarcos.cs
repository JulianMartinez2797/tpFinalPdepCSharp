using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PiratasDelCaribe;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaBarcos
    {
        [TestMethod]
        // Testeando: "El capitan de un barco es el tripulante con mayor poder de mando"
        public void CapitanDeUnBarco()
        {
            //Arrange
            var unGuerrero = new Guerrero(150, 5, 10);
            List<String> ingredientes = new List<String>();
            ingredientes.Add("tomate");
            ingredientes.Add("arroz");
            ingredientes.Add("carne");
            var unCocinero = new Cocinero(100, 10, ingredientes);
            var unNavegador = new Navegador(5, 10);
            List<ITripulante> tripulantes = new List<ITripulante>();
            tripulantes.Add(unGuerrero);
            tripulantes.Add(unCocinero);
            tripulantes.Add(unNavegador);
            var armadaInglesa = ArmadaInglesa.obtenerInstancia();
            var jackSparrow = JackSparrow.obtenerInstancia();
            var unBarco = new Barco(50, 100, 50, tripulantes, armadaInglesa);
            //Act
            var resultado = unBarco.capitan();
            //Assert
            Assert.AreEqual(unNavegador, resultado);
        }
        [TestMethod]
        /* Testeando: "La fuerza de un barco es la 
        sumatoria del poder de mando de todos sus tripulantes"*/

        public void FuerzaDeBarco()
        {
            //Arrange
            var unGuerrero = new Guerrero(150, 5, 10);
            List<String> ingredientes = new List<String>();
            ingredientes.Add("tomate");
            ingredientes.Add("arroz");
            ingredientes.Add("carne");
            var unCocinero = new Cocinero(100, 10, ingredientes);
            var unNavegador = new Navegador(5, 10);
            List<ITripulante> tripulantes = new List<ITripulante>();
            tripulantes.Add(unGuerrero);
            tripulantes.Add(unCocinero);
            tripulantes.Add(unNavegador);
            var armadaInglesa = ArmadaInglesa.obtenerInstancia();
            var jackSparrow = JackSparrow.obtenerInstancia();
            var unBarco = new Barco(50, 100, 50, tripulantes, armadaInglesa);
            //Act
            var resultado = unBarco.fuerza();
            //Assert
            Assert.AreEqual(180, resultado);
        }
    }
}
