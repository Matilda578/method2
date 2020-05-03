using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            static void HaveAnice()
            {
                Console.WriteLine("Have a nice day!");
            }
            
            {
                string str1;

                Console.Write("Please input a name : ");
                str1 = Console.ReadLine();

                Console.WriteLine(str1);
                {
                    Console.WriteLine("Welcome friend " + str1 + " !");
                }
                HaveAnice();
            }
        }
    }
}