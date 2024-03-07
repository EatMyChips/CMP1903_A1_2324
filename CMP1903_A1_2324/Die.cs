using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property

        public int DiceRoll { get; private set; }
        private static Random _rand = new Random();

        //Method

        /// <summary>
        /// rolls a 6 sided dice
        /// </summary>
        /// <returns>
        /// the rolled value
        /// </returns>
        public int roll()
        {
            DiceRoll = _rand.Next(1, 7);
            Console.WriteLine("This roll gave: " + DiceRoll);

            return DiceRoll;
        }

    }
}
