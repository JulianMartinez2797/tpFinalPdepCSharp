using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PiratasDelCaribe{
    public class ArmadaInglesa: IBando{

        private static ArmadaInglesa instancia;
        public static ArmadaInglesa obtenerInstancia(){
            if(instancia == null){
                 instancia = new ArmadaInglesa();
            }
            return instancia;
        }
        private ArmadaInglesa(){}
        public void aplicarBonus(Barco unBarco){
           unBarco.aumentarMunicion((unBarco.municiones * 0.3)); 
        }
        public void quitarBonus(Barco unBarco){
            unBarco.aumentarMunicion((unBarco.municiones / 1.3));        
        }
    }

}