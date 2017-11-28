using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            number[0] = 101;
            number[1] = 102;
            number[2] = 103;
            number[3] = 104;
            number[4] = 105;
            //foreach loop example
            int count = 0;
            foreach(int k in number)
            {
                count++;
                Console.WriteLine("Number{0}={1}",count,k);
            }
            //for loop example
            /*for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Number{0}={1}",i,number[i]);
            }*/
            //break and continue use in loop example

            for(int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);
                /*if (i == 10)
                    break;*/
            }

        }
    }
}
