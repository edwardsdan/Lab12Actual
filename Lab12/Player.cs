using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RPS { get; set; }

        public abstract Roshambo generateRoshambo(Roshambo x);
    }
}
