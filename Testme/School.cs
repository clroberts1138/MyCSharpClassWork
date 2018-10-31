using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Testme
{
    public class School
    {
        public string DisplayGradeWord(char grade)
        {
            switch (grade)
            {
                case 'E':
                    return "Excellent";
                case 'V':
                    return "Very Good";
                case 'G':
                    return "Good";
                case 'A':
                    return "Average";
                case 'F': 
                    return "Fail";
                default:
                    return "Invalid Grade.";
            }
        }
    }
}