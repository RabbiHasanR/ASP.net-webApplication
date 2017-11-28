using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string userChoice;
             do
             {
                 Console.WriteLine("enter your target");
                 int num = int.Parse(Console.ReadLine());
                 int start = 0;
                 while (start <= num)
                 {
                     Console.Write(start + " ");
                     start++;
                 }

                 do
                 {
                     Console.WriteLine("enter your choice");
                     userChoice = Console.ReadLine().ToUpper();
                     if (userChoice != "YES" && userChoice != "NO")
                     {
                         Console.WriteLine("Invalid string.plz enter Yes or No");
                     }
                 } while (userChoice != "YES" && userChoice != "NO");
             } while (userChoice == "YES");*/
            int userchoice;
            int totalCost=0;
            string choice = string.Empty;
            do
            {
               
                do
                {
                    Console.WriteLine("Enter your choice 1-small,2-medium,3-large");
                    userchoice = int.Parse(Console.ReadLine());
                    switch (userchoice)
                    {

                        case 1:
                            totalCost += 1;
                            break;
                        case 2:
                            totalCost += 2;
                            break;
                        case 3:
                            totalCost += 3;
                            break;
                        default:
                            Console.WriteLine("Invalid user choice {0}", userchoice);
                            break;
                    }
                } while (userchoice != 1 && userchoice != 2 && userchoice != 3);
                do
                {
                    Console.WriteLine("Do you want to another coffe?");
                    choice = Console.ReadLine().ToUpper();
                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine("Invalid choice {0}.Please try again", choice);
                    }
                } while (choice != "YES" && choice != "NO");
            } while (choice == "YES");
            Console.WriteLine("Thank you for buying coffee");
            Console.WriteLine("Total cost is {0}",totalCost);
        }
    }
}
