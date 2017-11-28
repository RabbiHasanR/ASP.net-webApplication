using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Program.evenNumber(20);
            Console.WriteLine(p.add(5,4));
            ExampleMethod e = new ExampleMethod();
            Console.WriteLine("Max value is:{0}",e.maxValue(6,5));
            Console.WriteLine("Factorial value is:{0}",e.factorial(8));
            Console.WriteLine("Factorial1 value is:{0}", e.factorial1(8));
        }
        public static void evenNumber(int target)
        {
            
            for(int i = 0; i <= target; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public int add(int a,int b)
        {
            return a + b;
        }
    }
}
