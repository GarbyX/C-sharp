using System;

namespace MyApplication
{
  class Program
  {
    enum Position
    {
      First,
      Second,
      Third
    }
    static void Main(string[] args)
    {
      Position myVar = Position.Second;
      Console.WriteLine(myVar);
    }
  }
}
/*
Outputs: 
Second
*/
