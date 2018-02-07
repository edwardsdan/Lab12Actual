using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            int wins = 0;
            int losses = 0;
            Console.WriteLine("Hey there! What's your name?");
            Human UserName = new Human(Console.ReadLine());

            Player Opponent = RoshamboApp.ChooseOpponent();
            PlayGame(ref wins, ref losses, UserName, ref Opponent);
            Console.WriteLine($"You won {wins} and lost {losses}");
        }
        #endregion
            
        #region Game!
        public static void PlayGame(ref int wins, ref int losses, Human UserName, ref Player Opponent)
        {
            while (true)
            {
                Roshambo Input = UserName.generateRoshambo(new Roshambo());
                Roshambo AI = Opponent.generateRoshambo(Input);

                if (Opponent.Name == "Dr. K")
                {
                    Counter(ref wins, ref losses, UserName, Opponent, Input, AI);
                }
                if (Opponent.Name == "Grant Chirpus")
                {
                    Counter(ref wins, ref losses, UserName, Opponent, Input, AI);
                }
                if (Opponent.Name == "Hulk Hogan")
                {
                    Counter(ref wins, ref losses, UserName, Opponent, Input, AI);
                }

                if (Validate.Continue() == true)
                {
                    if (Validate.NewOpponent() == true)
                        Opponent = RoshamboApp.ChooseOpponent();
                    Console.Clear();
                }
                else
                    break;
            }
        }

        public static void Counter(ref int wins, ref int losses, Human UserName, Player Opponent, Roshambo Input, Roshambo AI)
        {
            Console.WriteLine($"{UserName.Name}: {Input}\n{Opponent.Name}:{AI.ToString()}");
            Console.WriteLine(WinorLoss(Input, AI));
            if (WinorLoss(Input, AI) == "You lose!")
                losses++;
            if (WinorLoss(Input, AI) == "You win!")
                wins++;
        }

        public static string WinorLoss(Roshambo User, Roshambo AI)
        {
            string UserString = User.ToString();
            string AIString = AI.ToString();
            
            if ((UserString == "rock" && AIString == "paper" ) || (UserString == "scissors" && AIString == "rock") || (UserString == "paper" && AIString == "scissors"))
                return "You lose!";
            else if ((UserString == "rock" && AIString == "scissors") || (UserString == "scissors" && AIString == "paper") || (UserString == "paper" && AIString == "rock"))
                return "You win!";
            else
                return "Draw!";
        }
        #endregion
    }
}
