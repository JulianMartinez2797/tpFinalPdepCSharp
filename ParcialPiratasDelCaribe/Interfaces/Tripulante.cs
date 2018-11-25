using System;
using System.Collections.Generic;
using System.Linq;


namespace PiratasDelCaribe{
    public interface ITripulante{
        double poderDeMando();
        bool esFuerte();
        void serHerido();
        void beberRonConJack();
        
        int energia { get; set; }
    }
}