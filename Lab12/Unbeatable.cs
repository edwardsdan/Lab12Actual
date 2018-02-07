using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Unbeatable:Player
    {
        public Unbeatable()
        {
            Name = "Hulk Hogan";
        }

        public override Roshambo generateRoshambo(Roshambo UserInput)
        {
            if (UserInput.ToString() == "rock")
                return Roshambo.paper;
            else if (UserInput.ToString() == "paper")
                return Roshambo.scissors;
            else
                return Roshambo.rock;
        }
    }
}
