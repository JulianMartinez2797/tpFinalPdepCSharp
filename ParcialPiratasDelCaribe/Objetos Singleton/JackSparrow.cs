using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PiratasDelCaribe{
     public class JackSparrow : ITripulante{
        public int energia { get; set; } = 500;
        int poderDePelea = 200;
        int inteligencia = 300;
        List<String> ingredientes = new List<String>();

        

        private static JackSparrow instancia;
        public static JackSparrow obtenerInstancia(){
             if(instancia == null){
                 instancia = new JackSparrow();
             }
             return instancia;
        }
        private JackSparrow(){
            ingredientes.Add("Botella de Ron");     
        }
        public double poderDeMando(){
             return (energia + poderDePelea + inteligencia); 
        }
        public void beberRonCon(ITripulante unTripulante){
             this.beberRonConJack();
             unTripulante.beberRonConJack();
        }
        public void beberRonConJack(){
             energia += 100;
        }
        public void serHerido(){ //cuando hieren a jack, se va a la mitad su inteligencia y poder de pelea
            poderDePelea = poderDePelea / 2;
            inteligencia = inteligencia / 2;
        }
        public bool esFuerte(){
             return poderDeMando() > 100;
        }
        public void agregarIngredienteRobado(string unIngrediete){
             ingredientes.Add(unIngrediete);
        }
        
     } 
}