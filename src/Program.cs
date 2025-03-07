using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string varName;
      // string input;
      int varAge, varHeight, varWeight;
      varName = Console.ReadLine();
      // varName = "LOY SUAN FUH"; 
      varAge = 45;
      varHeight = 170;
      varWeight = 75;
      Console.WriteLine("My name is " + varName + " and my age is " + varAge + varAge); 
      // input = Console.ReadLine();
      // Console.WriteLine(input);

      Console.Write(varAge + varHeight);

    }
  }
}