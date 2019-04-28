using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial_Finder
{
  class Loop
  {
    public double CalculateFactorial(double input)
    {
      if(input == 0)
      {
        return 1;
      }
      else
      {
        double currentValue = 1;
        for(double i = input; i > 0; i--)
        {
          currentValue *= i;
        }
        return currentValue;
      }
    }
  }
}
