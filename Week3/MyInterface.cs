using System;

namespace Week3
{
    public interface IMyInterface
    {
        void MyCoolMethod();
        void CalculateArea(int length, int Height);
    }

    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    public interface ITest
    {
        string TestMethod();
    }

    public interface abc : IMyInterface
    {
       void xyz();
    }

}