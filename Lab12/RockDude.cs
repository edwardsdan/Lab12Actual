using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RockDude:Player
    {
        public RockDude()
        {
            Name = "Grant Chirpus";
        }
            
        public override Roshambo generateRoshambo(Roshambo x)
        {
            return Roshambo.rock;
        }
    }
}
