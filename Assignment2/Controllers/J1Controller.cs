using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController

    {
        [Route("api/J1/Menu/{burger}/{drink}/{sideOrder}/{dessert}")]

        [HttpGet]

        /// <summary>
        /// This method takes 4 integer inputs corrseponding to the choice of the 4 items in the menu, adds the total calories of all 4 items and returns it.
        /// <example>api/J1/Menu/{burger}/{drink}/{sideOrder}/{dessert}</example>
        /// <tests> api/J1/Menu/4/4/4/4 returns 0</tests>
        /// <tests> api/J1/Menu/1/2/3/4 returns 691</tests>
        /// <tests> api/J1/Menu/2/2/2/2 returns 914</tests>
        /// <param> 4 integers, namely:  
        ///  name="burger"
        ///  name="drink"
        ///  name="sideOrder"
        ///  name="dessert" </param>
        /// <returns> A message plus the total calorie count ("Your total calorie count is: " + totalCalories) </returns>
      

        public string Menu(int burger, int drink, int sideOrder, int dessert)
        {
            int burgerCalorie = 0, drinksCalorie = 0, sideorderCalorie = 0, dessertCalorie = 0, totalCalories = 0;


            if (burger == 1)
            {
                burgerCalorie = 461;
            }
            else if (burger == 2)
            {
                burgerCalorie = 431;
            }
            else if (burger == 3)
            {
                burgerCalorie = 420;
            }
            else if (burger == 4)
            {
                burgerCalorie = 0;
            }
            else
            {
                Console.WriteLine("wrong choice entered for burger");
            }

            if (drink == 1)
            {
                drinksCalorie = 130;
            }
            else if (drink == 2)
            {
                drinksCalorie = 160;
            }
            else if (drink == 3)
            {
                drinksCalorie = 118;
            }
            else if (drink == 4)
            {
                drinksCalorie = 0;
            }
            else
            {
                Console.WriteLine("wrong choice entered for drinks");
            }

            if (sideOrder == 1)
            {
                sideorderCalorie = 100;
            }
            else if (sideOrder == 2)
            {
                sideorderCalorie = 57;
            }
            else if (sideOrder == 3)
            {
                sideorderCalorie = 70;
            }
            else if (sideOrder == 4)
            {
                sideorderCalorie = 0;
            }
            else
            {
                Console.WriteLine("wrong choice entered for Side Order");
            }

            if (dessert == 1)
            {
                dessertCalorie = 167;
            }
            else if (dessert == 2)
            {
                dessertCalorie = 266;
            }
            else if (dessert == 3)
            {
                dessertCalorie = 75;
            }
            else if (dessert == 4)
            {
                dessertCalorie = 0;
            }
            else
            {
                Console.WriteLine("wrong choice entered for Side Order");
            }

            totalCalories = burgerCalorie + drinksCalorie + sideorderCalorie + dessertCalorie;

            return "Your total calorie count is: " + totalCalories;
        }
    }
}
/*
 
            //SWITCH METHOD:

            Alternate method employing switch - case (employed when the number of cases are high)
             
            switch (burger)
            {
                case 1: burgerCalorie = 461; break;
                case 2: burgerCalorie = 431; break;
                case 3: burgerCalorie = 420; break;
                case 4: burgerCalorie = 0; break;
                default: Console.WriteLine("wrong choice entered for burger"); break;
            }

            switch (drink)
            {
                case 1: drinksCalorie = 130; break;
                case 2: drinksCalorie = 160; break;
                case 3: drinksCalorie = 118; break;
                case 4: drinksCalorie = 0; break;
                default: Console.WriteLine("wrong choice entered for drink"); break;
            }

            switch (sideOrder)
            {
                case 1: sideorderCalorie = 100; break;
                case 2: sideorderCalorie = 57; break;
                case 3: sideorderCalorie = 70; break;
                case 4: sideorderCalorie = 0; break;
                default: Console.WriteLine("wrong choice entered for sideOrder"); break;
            }

            switch (dessert)
            {
                case 1: dessertCalorie = 167; break;
                case 2: dessertCalorie = 266; break;
                case 3: dessertCalorie = 75; break;
                case 4: dessertCalorie = 0; break;
                default: Console.WriteLine("wrong choice entered for dessert"); break;
            } 

            totalCalories = burgerCalorie + drinksCalorie + sideorderCalorie + dessertCalorie;

            return "Your total calorie count is: " + totalCalories; */