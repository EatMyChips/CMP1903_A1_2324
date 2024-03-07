﻿using System;
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

        //Method

        public void testDiceRoll(int roll)
        {
            Debug.Assert(roll <= 6 || roll >= 1, "roll is out of range");
        }


        public void testGame(List<int> rolls)
        {
            int total = 0;

            foreach (int i in rolls) 
            {
                total += i;
            }

            Debug.Assert(total <= 6 * rolls.Count || total >= rolls.Count, "total is out of range");
        }



    }
}
