using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    class RoshamboApp
    {
        public static Player ChooseOpponent()
        {
            Console.WriteLine("Would you like to play against GrantChirpus, DoctorK or HulkHogan? (g/k/h)");
            string Opponent = Console.ReadLine().ToLower();
            
            while (true)
            {
                if (Regex.IsMatch(Opponent, "^(doctork|k)$"))
                {
                    return new HardMode();
                }
                else if (Regex.IsMatch(Opponent, "^(g|grant|grantchirpus)$"))
                {
                    return new RockDude();
                }
                else if (Regex.IsMatch(Opponent, "^(h|hulk|hulkhogan)$"))
                    return new Unbeatable();
                else
                {
                    Console.WriteLine("That didn't sound like a name! Try again!");
                    Opponent = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
