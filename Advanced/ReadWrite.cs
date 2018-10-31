using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ReadWrite
    {
        public ReadWrite()
        {
            // Create a file called test.txt in the current directory:
            using (Stream s = new FileStream("testme.txt", FileMode.Create))
            {
                Console.WriteLine(s.CanRead);    //True
                Console.WriteLine(s.CanWrite);   //True
                Console.WriteLine(s.CanSeek);    //True

                s.WriteByte(101);
                s.WriteByte(102);
                byte[] block = { 1, 2, 3, 4, 5 };
                s.Write(block, 0, block.Length); //Write Block of 5 bytes

                Console.WriteLine(s.Length);  //7
                Console.WriteLine(s.Position); // 7
                s.Position = 0;        //Move back to the Start

                Console.WriteLine(s.ReadByte()); //101
                Console.WriteLine(s.ReadByte()); //102

                //Read from the stream back into the block array:
                Console.WriteLine(s.Read(block, 0, block.Length)); //5


                //Assuming the last Read retruned 5, we'll be at
                // the end of the file, so Read will now return 0:
                Console.WriteLine(s.Read(block, 0, block.Length)); // 5

                //Assuming the last Read returned 5, we'll be at
                // the end of the file, so Read will now return 0;
                Console.WriteLine(s.Read(block, 0, block.Length)); //0

            }
        }
       
    }
}
