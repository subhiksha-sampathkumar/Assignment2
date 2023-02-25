using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method takes message text string by string until halt is pressed, 
        /// calculates the number of key presses for each text message string and returns the total number of key press required.
        /// <example>api/J3</example>
        /// <tests> api/J3:message entered: how, are, and you: outputs 6, 6 and 8</tests>
        /// <param> the string that is read using Readline statement  </param>
        /// <returns> Outputs the number of presses for each message to the console</returns>
        /// Procedure to read strings from console is not known, so I have written the logic for the required action in the GET method. 
        /// Shall incorporate in the right way after learning.
        /// </summary>
        public int Get()
        {
            string[] msgTxt = new string[100];
            string rdstr, currString;          
            char letter;
            int j = 0, k = 0, currLen = 0;
            int numPress = 0; int totalPress = 0;
               int[] totalPress1 = new int[100];

            do
            {
                rdstr = Console.ReadLine();
                msgTxt[j] = rdstr;
                j++;
               
            }
            while (rdstr != "halt");

            //k is less than j here as number of presses for 'halt' is not to be counted 
            for (k = 0; k < j; k++) 
            {
                currString = msgTxt[k];
                currLen = currString.Length;             


                for(int l = 0; l <= currLen; l++)
                {
                    letter = currString[l];

                    switch (letter)
                    {
                        case 'a': 
                        case 'd':
                        case 'g': 
                        case 'j': 
                        case 'm':
                        case 'p':
                        case 't': 
                        case 'w':
                        case ' ':
                            numPress = 1;
                            totalPress1[j] += numPress;
                            break;

                        case 'b':
                        case 'e':
                        case 'h':
                        case 'k':
                        case 'n':
                        case 'q':
                        case 'u':
                        case 'x':
                            numPress = 2;
                            totalPress1[j] += numPress;
                            break;

                        case 'c':
                        case 'f':
                        case 'i':
                        case 'l':
                        case 'o':
                        case 'r':
                        case 'v':
                        case 'y':
                            numPress = 3;
                            totalPress1[j] += numPress;
                            break;

                        case 's': 
                        case 'z': 
                            numPress = 4;
                            totalPress1[j] += numPress;
                            break;

                    }
                    
                }
                
            }
           for (int m = 0; m<=j; m++)
            {
                Console.WriteLine(totalPress1[m]);
            }
            return 0;
        }
    }
}
