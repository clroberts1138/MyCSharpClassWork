using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Homework3;


namespace Homework6
{
    public class ArrayListPractice
    {
        public ArrayListPractice()
        {
            Console.WriteLine("This section is the ArrayList Section");
            ArrayList arrayList = new ArrayList();
            Bicycle myBikeA = new Bicycle();
            DeluxeBike myBikeB = new DeluxeBike();
            MultiGearBike myBikeC = new MultiGearBike();

            arrayList.Add(myBikeA);
            arrayList.Add(myBikeB);
            arrayList.Add(myBikeC);
            Console.WriteLine("Count = " + arrayList.Count);

            foreach (Object obj in arrayList)
            {
                Console.WriteLine("type = " + obj);
            }

            Console.WriteLine("End of ArrayList section");
            MyListExample2();
        }

        public void MyListExample2()
        {
            Console.WriteLine("This section is the LIST<> Section");
            List<Bicycle> myBikes = new List<Bicycle>();
            myBikes.Add(new Bicycle() { Color = "Red"});
            myBikes.Add(new Bicycle() { Color = "Silver"});
            myBikes.Add(new Bicycle() { Color = "Purple"});

            foreach (Bicycle bicycle in myBikes)
            {
                Console.WriteLine(bicycle);
            }
            
            List<DeluxeBike> myBikesB = new List<DeluxeBike>();
            myBikesB.Add(new DeluxeBike() { Color = "Red2" });
            myBikesB.Add(new DeluxeBike() { Color = "Silver2" });
            myBikesB.Add(new DeluxeBike() { Color = "Purple2" });

            foreach (DeluxeBike bicycle2 in myBikesB)
            {
                Console.WriteLine(bicycle2);
            }
            
            List<MultiGearBike> myBikesC = new List<MultiGearBike>();
            myBikesC.Add(new MultiGearBike() { Color = "Red3" });
            myBikesC.Add(new MultiGearBike() { Color = "Silver3" });
            myBikesC.Add(new MultiGearBike() { Color = "Purple3" });

            foreach (MultiGearBike bicycle3 in myBikesC)
            {
                Console.WriteLine(bicycle3);
            }
            Console.WriteLine("End of the LIST<> Section");

            Console.WriteLine("The difference between the List<> and the ArrayList is that the List<> requires the objects to be the same type. So I had to separate out Bicycle from DeluxeBike and MultiGearBike");
            
        }
    }
}
