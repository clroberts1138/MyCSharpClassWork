using System;

namespace Fundamentals
{
    public static class Utility
    {
        const int _myFirst = 5;
        static int _mySecond = 7;
       static Utility()
       {
           _mySecond = 10;
           Console.WriteLine("Utility Constructor");
       }
       
       public static int AddTwoNumbers(int value1, int value2 = _myFirst)
       {
           Console.WriteLine("_mySecond:" + _mySecond);
           Console.WriteLine("Value 1: " + value1);
           value1 += _mySecond + value1;
           Console.WriteLine("_mySecond:" + _mySecond);
           Console.WriteLine("Value 1: " + value1);
           Console.WriteLine("Value2 : " + value2);
           return value1 + value2;
       }   
    }
}