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

        public List<int> Rolls = new List<int>();

        private static Die _dice = new Die();

        //Methods

        /// <summary>
        /// Main game code that is run for the player to play
        /// </summary>
        /// <returns>
        /// total of all the rolls
        /// </returns>
        public int GamePlay()
        {
            int _total = 0;
            bool _continuePlaying = true;
            string _input = "y";

            Rolls.Clear();

            while (_continuePlaying)
            {
                if (!(_input.Equals("y") || _input.Equals("Y") || _input.Equals("n") || _input.Equals("N")))
                {
                    Console.Write("Invalid Input! Enter Again (y/n): ");
                    _input = Console.ReadLine();
                }
                else
                {
                    if (_input.Equals("y") || _input.Equals("Y"))
                    {
                        Rolls.Add(_dice.roll());
                        Console.Write("Would you like to roll again? (y/n): ");
                        _input = Console.ReadLine();
                    }
                    else
                    {
                        _continuePlaying = false;
                    }

                }

            }

            foreach (int i in Rolls)
            {
                _total += i;
            }

            return _total;

        }

        /// <summary>
        /// Class that allows the code to be tested without user input
        /// </summary>
        /// <returns>
        /// total of all the rolls
        /// </returns>
        public int TestPlay()
        {
            int _total = 0;
            Rolls.Clear();

            for (int i = 0; i < 4; i++)
            {
                _total += _dice.roll();
            }

            return (_total);
        }

    }
}
