using System;

namespace Factorial_Finder
{
  class Program
  {
    static void Main(string[] args)
    {
      bool keepRunning = true;

      while(keepRunning)
      {
        Console.WriteLine("Please enter a number. We'll calculate the factorial of that number.");
        Console.WriteLine("You can type \"Q\" at any time to quit the program.");
        string input = Console.ReadLine();
        if(input.ToLower() == "q")
        {
          keepRunning = false;
          break;
        }
        else
        {
          try
          {
            double value = Convert.ToDouble(input);
            Loop loop = new Loop();
            Recursive recursive = new Recursive();
            double result = recursive.CalculateFactorial(value);
            Console.WriteLine($"The factorial of {input} is {result}.");
          }
          catch(FormatException)
          {
            Console.WriteLine("Invalid format. Please enter a whole number.");
            continue;
          }
        }
      }
    }
  }
}
