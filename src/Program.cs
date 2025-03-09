using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string varName = "John";
      // string input;
      int varAge, varHeight;
      varAge = Convert.ToInt32(Console.ReadLine());
      
      varHeight = 170;
      // varWeight = 75;
      Console.WriteLine("My name is " + varName + " and my age is " + varAge); 
      // input = Console.ReadLine();
      // Console.WriteLine(input);

      Console.Write(varAge + varHeight);

      bool IsPowerOfTwo(int x)
        {
            return (x > 0) && ((x & (x - 1)) == 0);
        }

      Console.WriteLine("Is the number a power of two?");
      int input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(IsPowerOfTwo(input));
      }
  }
}