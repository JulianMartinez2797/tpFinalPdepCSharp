using System;
using System.Collections.Generic;
using System.Linq;


namespace PiratasDelCaribe{
    public interface IBando{
        void aplicarBonus(Barco unBarco);
        void quitarBonus(Barco unBarco);
    }
}