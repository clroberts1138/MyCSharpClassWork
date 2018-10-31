using System;
using System.Text;

namespace Week3
{
    public class ClassFinalizerSample
    {
        public string City;
        public string State;

        public string Name { set; get; }
        public int Phone { set; get; }
        public string Address { set; get; }

        public ClassFinalizerSample() { }

        public ClassFinalizerSample(string name, int phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public ClassFinalizerSample(string name, string city = "Lees Summit", string state = "Missouri")
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        ~ClassFinalizerSample()
        {
            Console.WriteLine("Deconstructor Called");
        }

        public void NameOfExample(int value)
        {
            string nameValue = nameof(value);
            Console.WriteLine(nameValue);
        }
    }
}