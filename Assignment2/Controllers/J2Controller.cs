using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/diceGame/{m}/{n}")]

        [HttpGet]

        /// <summary>
        /// This method counts the number of occurences of a total sum of 10 when 2 dice with 'm' faces and 'n' faces are rolled
        /// <example>api/J2/diceGame/{m}/{n}</example>
        /// <tests> api/J2/diceGame/6/8 returns 5 total ways to get sum 10</tests>
        /// <tests> api/J2/diceGame/12/4 returns 4 ways to get sum 10</tests>
        /// <tests> api/J2/diceGame/3/3 returns 0 ways to get sum 10</tests>
        /// <tests> api/J2/diceGame/5/5 returns 1 way to get sum 10 </tests>
        /// <param> m = no of faces of dice 1 </param>
        /// <param> n = no of faces of dice 2 </param>
        /// <returns> Returns the number of ways in which number 10 is obtained when the dice are rolled (string1 + numChance + string2 + " to get the sum 10) </returns>
        /// </summary>

        public string diceGame(int m, int n)
        {
            // m = no of faces of dice 1
            // n = no of faces of dice 2

            int numChance = 0;
            // numChance is the number of chances that we are likely to get 10, when combining values of m and n.
            // make users enter a value for m and a value for n to calculate --
            // -- how many times they can can output 10 with different combinations of faces. 

            //nested for loop in which j loop corrseponding to the second dice is nested within the i loop corresponding to the first dice
            //first for loop corresponds to the first dice
            for (int i = 1; i <= m; i++) 
            
            {
            //second for loop corresponds to the second dice
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        numChance += 1;
                    } 
                }
            }

            //concatenation of strings in accordance with the number of chances being 1 or many
            var string1 = "There are ";
            var string2 = " ways";


            //manipulation of string to display results as mentioned in the question

            if (numChance == 5)
            {
                string2 = " total ways";
            }

            else if (numChance == 1) 
                {
                string1 = "There is ";
                string2 = " way";
                }

            {
                return string1 + numChance + string2 + " to get the sum 10";
            }
        }
    }
}
