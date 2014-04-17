using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower
{
    class Program
    {
        static void Main(string[] args)
        {

            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }
        static void ThrowDice(string diceString)
        //Here I created a function called ThrowDice and set it to the string diceString which is my parameter.
        {
            Console.WriteLine("Throwing: " + diceString);
            Console.Write("Results: ");
            //Here I used my parameter diceString and actually set it to a string "4d20".

            var diceThrow = diceString.Split('d');

            //Here I made an array called diceThrow and set it diceString.Split('d'), what this does is split diceString into different parts using the .Split method.

            int numRolls = Convert.ToInt32(diceThrow[0]);

            //Now i'm taking the number of rolls and converting my string to an integer using the method Convert.ToInt32.

            int numSides = Convert.ToInt32(diceThrow[1]);

            //Now i'm taking the number of sides then converting my array into an integer using the method Convert.ToInt32.
            var random = new Random();
            // Here I made a variable called random and set it to be a randomizer.
            var numGenerator = random.Next(1, numSides + 1);
            // Here I added a variable called numGenerator and set it to select a random number starting at one and going for whatever number of sides I have + 1.

            for (var i = 1; i <= numRolls; i++)
                //Here I am writing a for loop to start throwing some die for a set number of rolls.
            {
                numGenerator = random.Next(1, numSides + 1);
                //Here I am using  my number generator here and actually putting it into action!!
                Console.Write(numGenerator + " ");
                //Here I am actually having my thing write to the console.

            }
            Console.WriteLine();
            //This organizes my code so that when its ran the computer can separate the different throws and results.
        }



    }
}
