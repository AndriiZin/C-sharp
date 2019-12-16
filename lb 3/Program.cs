using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Перевірити істинність вислову: "Цифри даного тризначного числа утворюють геометричну прогресію".

            Console.WriteLine("Enter Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > -1000 && a < -99 || a > 99 && a < 1000 && a % 2 != 0)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine("This integer is odd a three - digit number");
                }
                else
                {
                    Console.WriteLine("It is not three - digit");
                }
            }
            else
            {
                Console.WriteLine("It is not a three - digit odd number");
            }
            Console.ReadKey();

        }
    }
}