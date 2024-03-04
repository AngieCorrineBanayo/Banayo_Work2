using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banayo_Work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Enter The Number");
            i = int.Parse(Console.ReadLine());
            if (i % 15== 3)
            {
                Console.WriteLine(i + " Is a Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(i + " Is a Odd Number");
                Console.ReadLine();
            }
        }
    }
}
    

