using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter size of Array : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter item Number {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Array:  ");
            Console.WriteLine(String.Join("\t", array));

            int minElement = array[0];
            int maxElement = array[0];
            int minNumb = 0;
            int maxNumb = 0;
            for (int i = 1; i < N; i++)
            {
                if (minElement > array[i])
                {
                    minElement = array[i];
                    minNumb = i;
                }

                else if (maxElement < array[i])
                {
                    maxElement = array[i];
                    maxNumb = i;
                }
            }
            int temp = array[minNumb];
            array[minNumb] = array[maxNumb];
            array[maxNumb] = temp;
            Console.WriteLine("Result : ");
            Console.WriteLine(String.Join("\t", array));
            Console.WriteLine("Min : {0}; Max : {1}", minElement, maxElement);
            Console.ReadLine();
        }
    }
}