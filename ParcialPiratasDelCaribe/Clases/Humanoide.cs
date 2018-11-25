using System;
using System.Collections.Generic;
using System.Linq;


namespace PiratasDelCaribe{
    public class Humanoide: ITripulante{
        public int energia { get; set; }
        int poderDePelea;
        
        public Humanoide(int unaEnergia, int unPoderDePelea){
            energia = unaEnergia;
            poderDePelea = unPoderDePelea;
        }
        public double poderDeMando(){
            return poderDePelea;
        }
        public bool esFuerte(){
            return (poderDeMando() > 100);
        }
        public void serHerido(){
            poderDePelea = poderDePelea / 2;
        }
        public void beberRonConJack(){
            poderDePelea = poderDePelea / 2;
        }
    }
}