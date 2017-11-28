using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class ExampleMethod
    {
        public int maxValue(int a,int b)
        {
            int result;
            if (a > b)
                return result = a;
            else
                return result = b;
        }
        //recursion method factorial example
        public int factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * factorial(num - 1);
        }
        //calculate factorial without recursion
        public int factorial1(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
            {
                int result = 1;
                for(int i = 1; i <= num; i++)
                {
                    result = result * i;
                }
                return result;
            }
        }
        //fibonacci calculate
        public void fibonacci(int num)
        {
            int a = 0, b = 1, c = 0;
            Console.
        }
    }
}
