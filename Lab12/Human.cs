using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    class Human:Player
    {
        public Human(string name)
        {
            Name = name;
        }

        public override Roshambo generateRoshambo(Roshambo x)
        {
            Console.WriteLine("Rock, paper, or scissors? (r,p,s / 1,2,3)");
            string Input = Console.ReadLine().ToLower();

            while (true)
            {
                if (Regex.IsMatch(Input, "^(r|rock|1)$"))
                    return (Roshambo)1;
                else if (Regex.IsMatch(Input, "^(p|paper|2)$"))
                    return (Roshambo)2;
                else if (Regex.IsMatch(Input, "^(s|scissors|3)$"))
                    return (Roshambo)3;
                else
                {
                    Console.WriteLine("Invalid input! Try again!");
                    Input = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
