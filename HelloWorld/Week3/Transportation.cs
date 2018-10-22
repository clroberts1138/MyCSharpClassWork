using System;
using System.Text;

namespace Week3
{
    /*
        An abstract class enables you to create classes and class members that are incomplete
        and must be implemented in a derived(child) class. An abstract class can not be instantiated.
        They provide a common definition of a base class that multiple child classes can share.
     */
    public abstract class Transportation
    {
        public abstract void Size();
        public abstract void Speed();
        public abstract void Weight();
    }
}