using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    double [] EvenNum  = new double[10];
    double [] OddNum = new double [10];

    for(int pos = 0; pos < 10; pos++)
    {
      Console.WriteLine("Enter a number");

      double given_num = Convert.ToDouble(Console.ReadLine());

      if (given_num % 2 == 0)
      {
        EvenNum[pos]=(given_num);
      }
      else
      {
        OddNum[pos]=(given_num);
      }
    }
    var sort_odd = OddNum.OrderByDescending(c=> c).ToArray();
    Array.Sort(EvenNum);
    foreach(double value in sort_odd)
    {
      Console.Write(value + " ");
    }
    foreach(double value2 in EvenNum)
    {
      Console.Write(value2 + " ");
    }
    double odd_sum = OddNum.Sum();
    Console.WriteLine("Sum of odd numbers is " + odd_sum);

    double even_sum = EvenNum.Sum();
    Console.WriteLine("Sum of even numbers is " + even_sum);
  }
}