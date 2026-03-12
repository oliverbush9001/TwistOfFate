using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TO DO:
 * Add function for changing the color of a string of text to show an object is interactable.
 * 
 * 
 * 
 */

namespace TwistOfFate
{
    public static class Utility
    {
        //example conversion methods
        public static int ConvertStringToInteger(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }

            return 0;
        }
        public static float ConvertStringToFloat(string s)
        {
            if (float.TryParse(s, out float result))
            {
                return result;
            }

            return 0;
        }
        public static double ConvertStringToDouble(string s)
        {
            if (double.TryParse(s, out double result))
            {
                return result;
            }

            return 0;
        }

        //public static void Print(string output)
        //{
        //    Console.WriteLine(output);
        //}

        public static void Print(string input) => Console.WriteLine(input);

        public static void PrintSpace() => Console.WriteLine();
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

    }
}
