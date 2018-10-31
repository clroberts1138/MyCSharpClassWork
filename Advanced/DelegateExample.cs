using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class DelegateExample
    {
        public delegate int TheMagicNumber(int _magicNumber);


        public DelegateExample(int _magicNumber)
        {
            Console.WriteLine(_magicNumber);
        }

        public int TheLuckyNumber()
        {
            Random rnd = new Random();
            int _magicNumber = rnd.Next(1, 255);
            return _magicNumber;
        }
    }
}
