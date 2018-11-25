using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiratasDelCaribe{
      class UnionPirata: IBando{

        private static UnionPirata instancia;
        public static UnionPirata obtenerInstancia(){
            if(instancia == null){
                 instancia = new UnionPirata();
            }
            return instancia;
        }
        private UnionPirata(){}
        public void aplicarBonus(Barco unBarco){
           unBarco.aumentarPoderDeFuego(60); 
        }
        public void quitarBonus(Barco unBarco){
            unBarco.aumentarPoderDeFuego(-60);        
        }
    }

}