using System;
using System.Text;

namespace Week3
{
    public static class StaticExample

    {
        private static string _myStaticVariable = "test variable";

        //private string _someString = "test second string";

        static StaticExample()
        {
            Console.WriteLine("static constructor");
        }

        public static int AddTwoNumbers(int value, int value2)
        {
            return value + value2;
        }

        public class Car : IEquatable<Car>
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }

            // Implementation of IEquatable<T> interface
            public bool Equals(Car car)
            {
                return this.Make == car.Make &&
                       this.Model == car.Model &&
                       this.Year == car.Year;
            }
        }

        public class Test : ITest
        {
            public string TestMethod()
            {
                return "Test";
            }
        }
    }
}