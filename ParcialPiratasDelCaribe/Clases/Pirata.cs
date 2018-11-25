using System;
using System.Collections.Generic;
using System.Linq;



namespace PiratasDelCaribe{
    public abstract class Pirata: ITripulante{
        public int energia { get; set; }
        public Pirata(int unaEnergia){
            energia = unaEnergia;
        }
        public abstract double poderDeMando();
        public virtual void beberRonConJack(){ //revisar virtual
            energia -= 50;
        }
        public bool esFuerte(){
            return (poderDeMando() > 100);
        }
        public abstract void serHerido();
    }

    public class Navegador: Pirata{
        int inteligencia;

        public Navegador(int unaEnergia, int unaInteligencia): base(unaEnergia){
            inteligencia = unaInteligencia;
        }
        public override double poderDeMando(){
            return Math.Pow(inteligencia,2);
        }
        public override void serHerido(){
            inteligencia = inteligencia/2;
        }
    }
    public class Cocinero: Pirata{
        int moral;
        List<String> ingredientes = new List<String>();
        public List<String> Ingredientes
        {
            get { return ingredientes; }
        }

        public Cocinero(int unaEnergia, int unaMoral, List<String> unosIngredientes): base(unaEnergia){
            moral = unaMoral;
            ingredientes = unosIngredientes;
        }
        public override double poderDeMando(){
            return moral * ingredientes.Count();
        }     
        public override void beberRonConJack(){
            base.beberRonConJack();
            string ingr =ingredienteRandom();
            ingredientes.Remove(ingr);
            JackSparrow.obtenerInstancia().agregarIngredienteRobado(ingr);            
            //tomar un random de un array 
        }
        public override void serHerido(){
            moral = moral/2;
        }
        public string ingredienteRandom(){
            Random rnd = new Random();
            return ingredientes[rnd.Next(ingredientes.Count)];
        }
    }
    public class Guerrero: Pirata{
        int poderDePelea;
        int vitalidad;

        public Guerrero(int unaEnergia, int unPoderDePelea, int unaVitalidad): base(unaEnergia){
            poderDePelea = unPoderDePelea;
            vitalidad = unaVitalidad;
        }
        public override double poderDeMando(){
            return poderDePelea * vitalidad;
        }
        public override void serHerido(){
            poderDePelea = poderDePelea / 2;
        }        
    }
}