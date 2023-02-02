using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace we_live
{
    internal class methods
    {
        public static void favs()
        {
            Console.WriteLine("hi what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("are you a he or she?");
            string gender = Console.ReadLine();
            Console.WriteLine("whats you favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("whats your favorite snack?");
            string snack = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{name} likes the color {color}, \n" +
                             $" and {gender} loves to snack on {snack}.");
        }

    }
}
