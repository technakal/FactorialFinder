using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial_Finder
{
  class Recursive
  {
    public double CalculateFactorial(double input)
    {
      if(input == 0)
      {
        return 1;
      }

      return input * CalculateFactorial(input - 1);
    }
  }
}
