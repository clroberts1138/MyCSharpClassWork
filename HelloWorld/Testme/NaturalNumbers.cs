using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Testme
{
    public class NaturalNumbers
    {
        public void CountMe(int max)
        {
            int i = 0;
            while (i <= max) // While this expression is true
            {
                //perform these actions after the expression is checked
                
                Console.WriteLine(i);
                i++;
            }
         }
     }
}
