using System;
using System.IO;


namespace Homework6
{
    public class TryCatchException
    {
        public TryCatchException()
        {
            try
            {
                StreamReader sr = File.OpenText("\\data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            finally
            {
                Console.WriteLine("Finally block was called");
            }
        }
    }
}