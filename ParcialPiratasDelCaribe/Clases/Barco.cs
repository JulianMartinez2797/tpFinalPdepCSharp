using System;
using System.Collections.Generic;
using System.Linq;


namespace PiratasDelCaribe{
    public class Barco{
        double resistencia;
        int poderDeFuego;
        public double municiones { get; set; }
        public List<ITripulante> tripulantes = new List<ITripulante>();
        IBando bando;

        public Barco(   int unaResistencia, int unPoderDeFuego, double unasMuniciones, List<ITripulante> unosTripulantes, IBando unBando){
            resistencia = unaResistencia;
            poderDeFuego= unPoderDeFuego;
            municiones = unasMuniciones;
            tripulantes = unosTripulantes; 
            bando = unBando;
        }

        public ITripulante capitan(){
            return tripulantesSegunPoderDeMando().First();
            //devuelve el maximo y no el objeto con el maximo
        }
        private List<ITripulante> tripulantesSegunPoderDeMando(){
            return tripulantes.OrderByDescending(trip => trip.poderDeMando()).ToList();
            //error revisar teniendo en cuenta "IorderedEnumerable"
        }
        public double fuerza(){
            return tripulantes.Sum((ITripulante unTripulante) => unTripulante.poderDeMando());
        }
        public void enfrentarseContra(Barco unBarco){
            if(this.fuerza() > unBarco.fuerza()){
                this.ganarEnfrentamiento();
                unBarco.perderEnfrentamiento();
            }else{
                this.perderEnfrentamiento();
                unBarco.ganarEnfrentamiento();
            }
        }
        public void perderEnfrentamiento(){
            foreach (ITripulante unTripulante in tripulantes){
                unTripulante.serHerido();
            }
            tripulantes.Clear(); //vaciar el array averiguar como
            resistencia = 0;
            poderDeFuego = 0;
            municiones = 0;
        }
        public void ganarEnfrentamiento(){
            //tripulantes.Add();
        }
        public void dispararCanionasoA(Barco unBarco,double cantidad){
            if(municiones < cantidad){
                Console.WriteLine("Municiones insuficientes");
                return;
            }
            municiones -= cantidad;
            unBarco.aumentarResistencia(-(50*cantidad));
            unBarco.tripulacionQueSobrevive();
        }
        public void cambiarBando(IBando nuevoBando){
            bando.quitarBonus(this);
            bando = nuevoBando;
            bando.aplicarBonus(this);
        }
        private void aumentarResistencia(double valor){
            resistencia += valor;
        }
        public List<ITripulante> tripulacionConMasDe20DeEnergia(){
            return tripulantes.Where((ITripulante unTripulante) => unTripulante.energia > 20).ToList();
        }
        public void tripulacionQueSobrevive(){
            tripulantes = tripulacionConMasDe20DeEnergia();
        }
        public void limpiarTripulacionDuplicada(){
            tripulantes = tripulantes.Distinct().ToList();
        }
        public void duplicarTripulacion(){
            tripulantes = tripulantes.Concat(tripulantes).ToList();
        }
        public void aumentarMunicion(double valor){
            municiones = Math.Max(0, municiones + valor);
        }
        public void aumentarPoderDeFuego(int valor){
            poderDeFuego += valor;
        }
        public bool estaDesolado()
        {
            return (resistencia + poderDeFuego + municiones) == 0;
        }

    }
}