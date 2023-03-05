using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int a, int b)
    {
      return a + b;
    }

    static double PlusMethod(double a, double b)
    {
      return a + b;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(10, 15);
      double myNum2 = PlusMethod(7.6, 9.45);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}

/*
Outputs:
Int: 25
Double: 17.05
*/
