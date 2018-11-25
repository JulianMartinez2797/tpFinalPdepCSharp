using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PiratasDelCaribe;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaBarcos
    {
        Guerrero unGuerrero;
        Navegador unNavegador;
        Cocinero unCocinero;
        JackSparrow jackSparrow;
        ArmadaInglesa armadaInglesa;
        Barco unBarco;
        Barco otroBarco;

        [TestCleanup]
        public void testClean()
        {
            unGuerrero = null;
            unNavegador = null;
            unCocinero = null;
            jackSparrow = null;
            armadaInglesa = null;
            unBarco = null;
            otroBarco = null;
        }

        [TestInitialize]
        public void testInit()
        {
            unGuerrero = new Guerrero(150, 5, 10);
            unNavegador = new Navegador(5, 10);
            List<String> ingredientes = new List<String>();
            ingredientes.Add("tomate");
            ingredientes.Add("arroz");
            ingredientes.Add("carne");
            unCocinero = new Cocinero(100, 10, ingredientes);
            jackSparrow = JackSparrow.obtenerInstancia();
            List<ITripulante> tripulantes = new List<ITripulante>();
            tripulantes.Add(unGuerrero);
            tripulantes.Add(unCocinero);
            tripulantes.Add(unNavegador);
            armadaInglesa = ArmadaInglesa.obtenerInstancia();
            unBarco = new Barco(50, 100, 10, tripulantes, armadaInglesa);
            otroBarco = new Barco(80, 40, 40, tripulantes, armadaInglesa);
        }

        [TestMethod]
        // Testeando: "El capitan de un barco es el tripulante con mayor poder de mando"
        public void CapitanDeUnBarco()
        {
            //Arrange
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
            //Act
            var resultado = unBarco.fuerza();
            //Assert
            Assert.AreEqual(180, resultado);
        }
        [TestMethod]
        // Testeando: "Un barco consigue el bonus del bando al cual pertenece"
        public void BarcoObtieneBonus()
        {
            //Arrange
            //Act
            armadaInglesa.aplicarBonus(unBarco);
            var resultado = unBarco.municiones;
            //Assert
            Assert.AreEqual(13, resultado);
        }
        [TestMethod]
        // Testeando: "Cuando un barco pierde un enfrentamiento, queda desolado"
        public void BarcoPierdeEnfrentamiento()
        {
            //Arrange
            //Act
            unBarco.perderEnfrentamiento();
            var resultado = unBarco.estaDesolado();
            //Assert
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        /* Testeando: "Cuando un barco intenta atacar a otro barco 
        con mas municiones de las que posee, no puede hacerlo"*/
        public void UnBarcoNoPuedeAtacarAOtroSinoTieneLasMunicionesSuficientes()
        {
            //Arrange
            //Act
            //Assert
        }

    }
}
