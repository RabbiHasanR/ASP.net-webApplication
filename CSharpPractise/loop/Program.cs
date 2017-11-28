using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int start = 0;
            //int sum = 0;
            //while (start <= a)
            //{

            //    sum += start;
            //    start += 1;

            //}
            //Console.WriteLine(sum);
            //Console.WriteLine("Enter 10 number");
            //int number;
            //int sum = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write("number{0}:",i);
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //double avg = sum / 10;
            //Console.WriteLine("sum:{0}",sum);
            //Console.WriteLine("Avarage is:{0}",avg);

            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //for(int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("{0}X{1}={2}", i,number,(i *number));
            //}
            /*
             //even and odd number 
             Console.WriteLine("Input number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
                if (i %2== 0)
                {
                    sum += i;
                    Console.WriteLine("Odd number is:{0} \n",i);
                }
            }
            Console.WriteLine("sum of the odd number is:{0}",sum);*/
            /*
            //pyramid 
            int rows = int.Parse(Console.ReadLine());
            //int k = 1;
            for(int i = 1; i <= rows; i++)
            {
                for(int n = rows; n >= 1; n--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    //Console.Write("{0} ",k++);
                    Console.Write("* ");
                    
                }
                Console.Write("\n");
                rows--;
            }*/
            /*
             //factorial calculate
              int num = int.Parse(Console.ReadLine());
            int f = 1;
            for(int i = 1; i <= num; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);*/
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for(int k = num; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ",i);
                }
                Console.Write("\n");
                num--;
            }
        }
    }
}
