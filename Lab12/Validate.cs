using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    partial class Validate
    {
        public static bool Continue()
        {
            Console.WriteLine("Play again? (y/n)");
            string Continue = Console.ReadLine().ToLower();

            while (true)
            {
                if (Regex.IsMatch(Continue, "^(n|no)$"))
                    return false;
                else if (Regex.IsMatch(Continue, "^(y|yes)$"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Try again!");
                    Continue = Console.ReadLine().ToLower();
                }
            }
        }

        public static bool NewOpponent()
        {
            Console.WriteLine("Would you like a new opponent? (y/n)");
            string YorN = Console.ReadLine().ToLower();
            while (true)
            {
                if (Regex.IsMatch(YorN, "^(n|no)$"))
                    return false;
                else if (Regex.IsMatch(YorN, "^(y|yes)$"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Do you kiss your mother with that mouth? Try again!");
                    YorN = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
