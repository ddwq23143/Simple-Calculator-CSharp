using System;
using System.IO;

namespace Calculator
{
    public class Main
    {
        public void Run()
        {
            int sum = 0, num1, num2;
            string action;
            
            Console.Write("Please enter a first number: "); 
            num1 = int.Parse(Console.ReadLine()); 
            Console.Write("Please enter a second number: "); 
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a action: "); 
            action = Console.ReadLine();
            
            if (action == "+") 
            { 
                sum = num1 + num2;
            }else if (action == "-")
            {
                sum = num1 - num2;
            }else if (action == "*")
            {
                sum = num1 * num2;
            }else if (action == "/")
            { 
                sum = num1 / num2; 
            }
            
            Console.WriteLine(sum);

            string path = @"YOUR_ADDRESS_FROM_FILE";
            
            File.AppendAllText(path, $"\n{num1}{action}{num2}={sum}");
        }
    }
}
