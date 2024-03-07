using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        Die dice = new Die();
        Testing test = new Testing();

        private List<int> rolls = new List<int>();

        private string input;

        public int total { get; private set; }

        //Methods

        public int GamePlay()
        {
            bool continuePlaying = true;
            rolls.Clear();
            input = "y";

            while (continuePlaying == true)
            {
                if (!(input.Equals("y") || input.Equals("Y") || input.Equals("n") || input.Equals("N")))
                {
                    Console.Write("Invalid Input! Enter Again (y/n): ");
                    input = Console.ReadLine();
                }
                else
                {
                    if (input.Equals("y") || input.Equals("Y"))
                    {
                        rolls.Add(dice.roll());
                        Console.Write("Would you like to roll again? (y/n): ");
                        input = Console.ReadLine();
                    }
                    if (input.Equals("n") || input.Equals("N"))
                    {
                        continuePlaying = false;
                    }

                }

            }

            foreach (int i in rolls)
            {
                total += i;
            }

            test.testGame(rolls);

            return total;

        }

    }
}
