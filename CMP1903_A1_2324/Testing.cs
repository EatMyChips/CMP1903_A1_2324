using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        private static Die _die = new Die();
        private static Game _game = new Game(); 

        //Method

        /// <summary>
        /// Tests the Dice class for any errors that could occur
        /// </summary>
        /// <param name="rolls"></param>
        public void TestDiceRoll(int rolls)
        {
            

            Console.WriteLine($"Testing rolls with {rolls} rolls.");
            for (int i = 0; i <= rolls; i++)
            {
                _die.roll();
                Debug.Assert(_die.DiceRoll <= 6 || _die.DiceRoll >= 1, "roll is out of range");
            }
            
        }


        /// <summary>
        /// Tests the game class for any errors that could occur
        /// </summary>
        /// <param name="tests"></param>
        public void TestGame(int tests)
        {
            int _total = 0;

            Console.WriteLine($"Testing Game {tests} times. ");

            for (int i = 0; i <= tests; i++)
            {
                _game.TestPlay();
                foreach (int j in _game.Rolls)
                {
                    _total += j;
                }
                Debug.Assert(_total <= 6 * _game.Rolls.Count || _total >= _game.Rolls.Count, "total is out of range");
            }
        }
    }
}
