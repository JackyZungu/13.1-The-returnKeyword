using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_The_returnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));


            cube(5);

        }
        static int cube (int number)
        {
            int result = number * number * number;

            return result;      
        }
    }
}
