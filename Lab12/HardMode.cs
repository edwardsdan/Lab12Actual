using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HardMode:Player
    {
        public HardMode()
        {
            Name = "Dr. K";
        }

        public override Roshambo generateRoshambo(Roshambo x)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 3);
            Roshambo SomeValue = (Roshambo)number;
            return SomeValue;
        }
    }
}
