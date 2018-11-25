using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PiratasDelCaribe{
      class ArmadaHolandesErrante: IBando{

        private static ArmadaHolandesErrante instancia;
        public static ArmadaHolandesErrante obtenerInstancia(){
            if(instancia == null){
                 instancia = new ArmadaHolandesErrante();
            }
            return instancia;
        }
        private ArmadaHolandesErrante(){}
        public void aplicarBonus(Barco unBarco){
           unBarco.duplicarTripulacion(); 
        }
        public void quitarBonus(Barco unBarco){
            unBarco.limpiarTripulacionDuplicada();        
        }
    }

}