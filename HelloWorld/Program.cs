using System;
using System.Text;
using System.Collections;
using Fundamentals;
using GenericApplication;
using HelloWorld.Testme;
using HelloWorld.Homework1;
using HelloWorld.Homework1RO;
using HelloWorld.Week2;
using HelloWorld.Week1;
using HelloWorld.Homework2;
using Homework3;
using Week3;
using Homework4;
using AbstractFactory;
using Builder;
using Adapter;
using Decorator;
using Facade;
using Singleton;
using System.Collections.Generic;
using Advanced;
using Homework5;
using Homework6;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Homework7;



namespace HelloWorld
{   /*This class represents Hello World */
    class Program
    {
        string s1 = "Type: ";
        string s2 = "Size: ";
        string s3 = "Buttons: ";
        string s4 = "Switches: ";
        string s5 = "Lights: ";
        string s6 = "Price:  ";

        static Dinosaur dino10;
        // Main method that runs when we run the build
        static void Main(string[] args)
        {
            string myChoice;

            do

            {
                // Print A Menu
                Console.WriteLine("Running Classwork\n");

                Console.WriteLine("1 - Section 1 - Work up to Homework 4");
                Console.WriteLine("2 - Section 2 - Homework 4 - Design Patterns Implementation for Boat");
                Console.WriteLine("3 - Section 3 - Homework 5 - Delegate Examples");
                Console.WriteLine("4 - Section 4 - Homework 6 - ArrayLists and TryCatch");
                Console.WriteLine("5 - Section 5 - Homework 7 - Async and LINQ");
                Console.WriteLine("6 - Section 6 - Advanced C Sharp");

                Console.WriteLine("Q - Quit\n");

                Console.WriteLine("Choice (1 - 6 or Q): ");

                // Retrieve the user's choice
                myChoice = Console.ReadLine();

                // Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "1":
                        Console.WriteLine("You wish to run Work up to Homework 4");
                        Menu1();
                        break;
                    case "2":
                        Console.WriteLine("You wish to run Design Patterns Implementation for Boat Project");
                        Menu2();
                        break;
                    case "3":
                        Console.WriteLine("You Wish to Homework 5 Delegate Demonstration");
                        Homework5();
                        break;
                    case "4":
                        Console.WriteLine("You Wish to Run Homework 6 - ArrayLists and TryCatch");
                        Homework6();
                        break;
                    case "5":
                        Console.WriteLine("You Wish to Run Homework 7 - Async and LINQ");
                        Homework7();
                        break;
                    case "6":
                        Console.WriteLine("You Wish to Run Advanced C Sharp");
                        Advanced_C_Sharp();
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }

                // Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // Keep going until the user wants to quit
        }

        public static void Menu1()
        {
            string myChoice;

            do

            {
                // Print A Menu
                Console.WriteLine("Running Exercises\n");

                Console.WriteLine("1 - Structures");
                Console.WriteLine("2 - First Week Examples");
                Console.WriteLine("3 - IterationExample");
                Console.WriteLine("4 - IterationExample2");
                Console.WriteLine("5 - ClassWork");
                Console.WriteLine("6 - SecondWeekExamples");
                Console.WriteLine("7 - ThirdWeekExamples");
                Console.WriteLine("8 - Homework1");
                Console.WriteLine("9 - Homework2");
                Console.WriteLine("10 - Homework3");
                Console.WriteLine("11 - TestArray");
                Console.WriteLine("12 - DinosaurTest");
                Console.WriteLine("13 - StringBuilderTest");
                Console.WriteLine("Q - Quit\n");

                Console.WriteLine("Choice (1 - 12 or Q): ");

                // Retrieve the user's choice
                myChoice = Console.ReadLine();

                // Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "1":
                        Console.WriteLine("You wish to run Structures");
                        Structures();
                        break;
                    case "2":
                        Console.WriteLine("You wish to run first week examples");
                        FirstWeekExamples();
                        break;
                    case "3":
                        Console.WriteLine("You wish to run iteration example");
                        IterationExample();
                        break;
                    case "4":
                        Console.WriteLine("You wish to run interation example 2");
                        IterationExample2();
                        break;
                    case "5":
                        Console.WriteLine("You wish to run ClassWork");
                        ClassWork();
                        break;
                    case "6":
                        Console.WriteLine("You wish to run Second Week Examples");
                        SecondWeekExamples();
                        break;
                    case "7":
                        Console.WriteLine("You wish to run Third Week Examples");
                        ThirdWeekExamples();
                        break;
                    case "8":
                        Console.WriteLine("You wish to run Homework1");
                        Homework1();
                        break;
                    case "9":
                        Console.WriteLine("You wish to run Homework2");
                        Homework2();
                        break;
                    case "10":
                        Console.WriteLine("You wish to run Homework3");
                        Homework3();
                        break;
                    case "12":
                        Console.WriteLine("You wish to run DinosaurTests");
                        DinosaurTests();
                        break;
                    case "13":
                        Console.WriteLine("You wish to run StringBuilderTest");
                        StringBuilderTest();
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }

                // Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // Keep going until the user wants to quit
        }
        public static void Menu2()
        {
            string myChoice;

            do

            {
                // Print A Menu for Homework 4
                Console.WriteLine("Running Homework 4\n");

                Console.WriteLine("1 - AbstractFactoryPatternDemo");
                Console.WriteLine("2 - BuilderPatternDemo");
                Console.WriteLine("3 - DecoratorPatternDemo");
                Console.WriteLine("4 - AdapterPatternDemo");
                Console.WriteLine("5 - SingletonPatternDemo");
                Console.WriteLine("6 - FacadePatternDemo");
                Console.WriteLine("Q - Quit\n");
                Console.WriteLine("Choice (1 - 6 or Q): ");

                // Retrieve the user's choice
                myChoice = Console.ReadLine();

                // Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "1":
                        Console.WriteLine("You wish to run AbstractFactoryPatternDemo");
                        AbstractFactoryPatternDemo();
                        break;
                    case "2":
                        Console.WriteLine("You wish to run BuilderPatternDemo");
                        BuilderPatternDemo();
                        break;
                    case "3":
                        Console.WriteLine("You wish to run DecoratorPatternDemo");
                        DecoratorPatternDemo();
                        break;
                    case "4":
                        Console.WriteLine("You wish to run AdapterPatternDemo");
                        AdapterPatternDemo();
                        break;
                    case "5":
                        Console.WriteLine("You wish to run SingletonPatternDemo");
                        SingletonPatternDemo();
                        break;
                    case "6":
                        Console.WriteLine("You wish to run FacadePatternDemo");
                        FacadePatternDemo();
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }

                // Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // Keep going until the user wants to quit
        }

        public static void Advanced_C_Sharp()
        {
            string myChoice;

            do
            {
                // Print A Menu for Advanced C Sharp
                Console.WriteLine("Running Advanced C Sharp Menu\n");

                Console.WriteLine("1 -  DelegateSample");
                Console.WriteLine("2 -  MultiDelegateSample");
                Console.WriteLine("3 -  EventSample");
                Console.WriteLine("4 -  LambdaSample");
                Console.WriteLine("5 -  ThreadingSample");
                Console.WriteLine("6 -  ThreadingSample2");
                Console.WriteLine("7 -  ResultCallBack");
                Console.WriteLine("8 -  ThreadingReturnSample");
                Console.WriteLine("9 -  CollectionSample");
                Console.WriteLine("10 - ExceptionSample");
                Console.WriteLine("11 - SimpleTaskExample");
                Console.WriteLine("12 - AsynchExample");
                Console.WriteLine("13 - myLinqExample");
                Console.WriteLine("14 - AnonymousTypeExample");
                Console.WriteLine("15 - x");
                Console.WriteLine("16 - x");
                Console.WriteLine("17 - x");
                Console.WriteLine("Q - Quit\n");
                Console.WriteLine("Choice (1 - 12 or Q): ");

                // Retrieve the user's choice
                myChoice = Console.ReadLine();

                // Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "1":
                        Console.WriteLine("You wish to run DelegateSample");
                        DelegateSample();
                        break;
                    case "2":
                        Console.WriteLine("You wish to run MultiDelegateSample");
                        MultiDelegateSample();
                        break;
                    case "3":
                        Console.WriteLine("You wish to run EventSample");
                        EventSample();
                        break;
                    case "4":
                        Console.WriteLine("You wish to run LambdaSample");
                        LambdaSample();
                        break;
                    case "5":
                        Console.WriteLine("You wish to run ThreadingSample");
                        ThreadingSample();
                        break;
                    case "6":
                        Console.WriteLine("You wish to run ThreadingSample2");
                        ThreadingSample2();
                        break;
                    case "7":
                        Console.WriteLine("You wish to run ResultCallBack");
                        ResultCallback(1);
                        break;
                    case "8":
                        Console.WriteLine("You wish to run ThreadingReturnSample");
                        ThreadingReturnSample();
                        break;
                    case "9":
                        Console.WriteLine("You wish to run CollectionSample");
                        CollectionSample();
                        break;
                    case "10":
                        Console.WriteLine("You wish to run ExceptionSample");
                        ExceptionSample();
                        break;
                    case "11":
                        Console.WriteLine("You wish to run SimpleTaskExample");
                        SimpleTaskExample();
                        break;
                    case "12":
                        Console.WriteLine("You wish to run MyAsyncExample");
                        MyAsyncExample();
                        break;
                    case "13":
                        Console.WriteLine("You wish to run myLinqExample");
                        MyLinqExample();
                        break;
                    case "14":
                        Console.WriteLine("You wish to run AnonymousTypeExample");
                        AnonymousTypeExample();
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }

                // Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // Keep going until the user wants to quit
        }   
            

    public void xyz()
        {
            System.Console.WriteLine("In xyz");
        }
        private static void Structures()
        {
            // Initialize:   
            CoOrds coords1 = new CoOrds();
            CoOrds coords2 = new CoOrds(10, 10);

            // Display results:
            Console.Write("CoOrds 1: ");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            Console.Write("CoOrds 2: ");
            Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.Read();

        }
        private static void FirstWeekExamples()
        {
            /**
           vehicle is a copy of Vehicle Class
           Instance with parameter constructor
           */
            Vehicle vehicle = new Vehicle("Chevy");
            vehicle.Color = "Blue";
            vehicle.WheelType = "Chrome";
            Console.WriteLine(vehicle.WheelType);

            //myVehicle is a copy of the Vehicle Class
            Vehicle myVehicle = new Vehicle();
            // Sets the value of color to red
            myVehicle.Color = "Red";
            myVehicle.OpenDoor();
            myVehicle.CloseWindow();

            // myCar inherits the public methods and properties of Vehicle
            Car myCar = new Car();

            myCar.Color = "Green";
            myCar.CloseWindow();
        }

        public static void IterationExample()
        {
            int i = 15;

            while (i < 20)
            {
                Console.WriteLine("My iteration");
                i++;
            }
        }

        private static void IterationExample2()
        {
            int j = 6;
            do
            {
                Console.WriteLine("My second Iteration");
                j++;
            } while (j < 17);
        }

        private static void ClassWork()
        {
            Square mySquare = new Square(3, 3);
            //     int length, height;
            var (length, height) = mySquare;
            mySquare.Deconstruct(out length, out height);
            Console.WriteLine(mySquare.Length);
            Console.WriteLine(length);
            Square yourSquare = new Square { Length = 5, Height = 5, Color = "Blue" };
            Square happySquare = new Square { Color = "brown" };


            //       Console.WriteLine(mySquare.Height);
            // https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct
        }

        private static void SecondWeekExamples()
        {
            AdditionalExamples myAdditional = new AdditionalExamples();
            Console.WriteLine("********");
            Console.WriteLine("UseParms");
            Console.WriteLine("********");
            myAdditional.UseParams(1, 2, 3, 4, 5);
            Console.WriteLine("********");
            Console.WriteLine("GetText");
            Console.WriteLine("********");
            Console.WriteLine(myAdditional.GetText("GetText String"));
            Console.WriteLine("********");
            Console.WriteLine("SomeMethod Without Parameters");
            Console.WriteLine("********");
            myAdditional.SomeMethod();
            Console.WriteLine("********");
            Console.WriteLine("SomeMethod With String Parameters");
            Console.WriteLine("********");
            myAdditional.SomeMethod("Text in Somemethod");
            Console.WriteLine("********");
            Console.WriteLine("SomeMethod With Integer Parameters");
            Console.WriteLine("********");
            Console.WriteLine(myAdditional.SomeMethod(1));
            Console.WriteLine("********");
            Console.WriteLine("Coalescing Example");
            Console.WriteLine("********");
            myAdditional.CoalescingExample();
            Console.WriteLine("********");
            Console.WriteLine("Elvis Operator Example");
            Console.WriteLine("********");
            myAdditional.ElvisOperatorExample();
            Console.WriteLine("********");
            Console.WriteLine("Boolean Example");
            Console.WriteLine("********");
            Console.WriteLine(myAdditional.UseUmbrella(true, true, true));

            NumericTypes myNumericTypes = new NumericTypes();
            Console.WriteLine("********");
            Console.WriteLine("ConvertFloatToInt Example");
            Console.WriteLine("********");
            myNumericTypes.ConvertFloatToInt();
            Console.WriteLine("********");
            Console.WriteLine("LongFromInt Example without Parameters");
            Console.WriteLine("********");
            myNumericTypes.LongFromInt();
            Console.WriteLine("********");
            Console.WriteLine(" LongFromInt Example with Integer Parameter");
            Console.WriteLine("********");
            Console.WriteLine(myNumericTypes.LongFromInt(1));
            Console.WriteLine("********");
            Console.WriteLine(" IncrementDecrement Example");
            Console.WriteLine("********");
            myNumericTypes.IncrementDecrement();
            Console.WriteLine("********");
            Console.WriteLine(" GetSomeTypes Example");
            Console.WriteLine("********");
            myNumericTypes.GetSomeTypes();
            Console.WriteLine("********");
            Console.WriteLine(" BasitMath Example");
            Console.WriteLine("********");
            myNumericTypes.BasicMath();
            Console.WriteLine("********");
            Console.WriteLine(" CheckOperatorType Example");
            Console.WriteLine("********");
            myNumericTypes.CheckOperatorType();
            Console.WriteLine("********");
            Console.WriteLine(" SpecialValues Example");
            Console.WriteLine("********");
            myNumericTypes.SpecialValues();
            Console.WriteLine("********");
            Console.WriteLine(" MyCheckComparison Example");
            Console.WriteLine("********");
            myNumericTypes.MyCheckComparison();
            ReferenceTypes myReference = new ReferenceTypes();
            Console.WriteLine("********");
            Console.WriteLine(" JoiningStrings Example");
            Console.WriteLine("********");
            myReference.JoiningStrings();
            Console.WriteLine("********");
            Console.WriteLine(" JoiningStringsWithBuilder Example");
            Console.WriteLine("********");
            myReference.JoinStringsWithBuilder();
            Console.WriteLine("********");
            Console.WriteLine(" PlaceHolderString Example");
            Console.WriteLine("********");
            myReference.PlaceHolderString();
            Console.WriteLine("********");
            Console.WriteLine(" CompareStrings Example");
            Console.WriteLine("********");
            myReference.CompareStrings();
            Console.WriteLine("********");
            Console.WriteLine(" CharType Example");
            Console.WriteLine("********");
            myReference.CharType();
            Console.WriteLine("********");
            Console.WriteLine(" ArraySingleSample Example");
            Console.WriteLine("********");
            myReference.ArraySingleSample();
            Console.WriteLine("********");
            Console.WriteLine(" ArrayRectanglurSample Example");
            Console.WriteLine("********");
            myReference.ArrayRectanglurSample();
            Console.WriteLine("********");
            Console.WriteLine(" ArrayJaggedSample Example");
            Console.WriteLine("********");
            myReference.ArrayJaggedSample();
            Statements myStatements = new Statements();
            Console.WriteLine("********");
            Console.WriteLine(" Constant Example");
            Console.WriteLine("********");
            myStatements.ConstantExample();
            Console.WriteLine("********");
            Console.WriteLine(" ExpressionStatement Example");
            Console.WriteLine("********");
            myStatements.ExpressionStatementExample(1, 2);
            Console.WriteLine("********");
            Console.WriteLine(" If Statement Basic Example");
            Console.WriteLine("********");
            myStatements.IfStatementBasicExample(1, 2);
            Console.WriteLine("********");
            Console.WriteLine(" If Statement Chain Example");
            Console.WriteLine("********");
            myStatements.IfStatementChainExample("Sunday");
            Console.WriteLine("********");
            Console.WriteLine(" Switch Statement Example");
            Console.WriteLine("********");
            myStatements.SwitchStatemntExample("Monday");
            Console.WriteLine("********");
            Console.WriteLine(" While Loop Example");
            Console.WriteLine("********");
            myStatements.WhileLoopExample();
            Console.WriteLine("********");
            Console.WriteLine(" DoWhile Loop Example");
            Console.WriteLine("********");
            myStatements.DoWhileLoopExample();
            Console.WriteLine("********");
            Console.WriteLine(" For Loop Example");
            Console.WriteLine("********");
            myStatements.ForLoopExample();
            Console.WriteLine("********");
            Console.WriteLine(" For Each Loop Example");
            Console.WriteLine("********");
            myStatements.ForEachLoopExample();
            Console.WriteLine("********");
            Console.WriteLine(" Jump Statement Example");
            Console.WriteLine("********");
            Console.WriteLine(myStatements.JumpStatementExample("Monday"));
            ValueTypesContinues myValueType = new ValueTypesContinues();
            int x = 3;
            int y = 4;
            String myTestName, myTestSecondName;

            Console.WriteLine("********");
            Console.WriteLine(" Enum Example");
            Console.WriteLine("********");
            myValueType.EnumSample();
            Console.WriteLine("********");
            Console.WriteLine(" REF Example");
            Console.WriteLine("********");
            Console.WriteLine("The Value before Ref Sample for X is " + x);
            myValueType.RefSample(ref x);
            Console.WriteLine("The Value after Ref Sample for X is " + x);
            Console.WriteLine("********");
            Console.WriteLine(" OUT Example");
            Console.WriteLine("********");
            myValueType.OutSample("Johnny Quest", out myTestName, out myTestSecondName);
            Console.WriteLine("myTestName: " + myTestName + ' ' + myTestSecondName);
            Console.WriteLine(myTestName);
            Console.WriteLine(myTestSecondName);

            // Struct Call
            TestStruct teststruct1 = new TestStruct();
            TestStruct teststruct2 = new TestStruct(10, 10);

        }

        private static void ThirdWeekExamples()
        {
            Console.WriteLine("Instance of AccessModifiers() called myAccMod1");
            AccessModifiers myAccMod1 = new AccessModifiers();
            Console.WriteLine("Instance of AccessModifiers() called myAccMod2");
            AccessModifiers myAccMod2 = new AccessModifiers("This one Has a String");
            Console.WriteLine("Indexer Example");
            myAccMod1.IndexerExample();
            Console.WriteLine("ClassFinalizerSample Class Definitions");
            ClassFinalizerSample myCFS = new ClassFinalizerSample();
            ClassFinalizerSample myCFS2 = new ClassFinalizerSample("Johnny Quest", 4538702);
            ClassFinalizerSample myCFS3 = new ClassFinalizerSample("Johnny Quest");
            Console.WriteLine("Class Grades Assignment");
            ClassGrades myClassGrades = new ClassGrades("Joe ", "Smith", 'E');
            (string firstName, string lastName, char Grades) = myClassGrades;
            Console.WriteLine($"Person Details: First Name: {firstName}, Last Name: {lastName}, Grade: {Grades}");
            Console.WriteLine("Example of using NameOf");
            Console.WriteLine(myClassGrades.MyGradeType());
            DevelopmentClass myDevelopment = new DevelopmentClass();
            int x, y;
            x = myDevelopment.ClassTotal;
            y = myDevelopment.RoomTotal;
            Console.WriteLine($"Class Total: {x}, RoomTotal: {y}");
            Hatchback myHatchback1 = new Hatchback();
            myHatchback1.Color();
            myHatchback1.Size();
            myHatchback1.Speed();
            myHatchback1.Weight();

            Console.WriteLine(StaticExample.AddTwoNumbers(1, 2));
            Console.WriteLine(Math.Abs(-10));

            String Name = "Bob";
            if (IsPalinDrome.IsPalindrome(Name))
            {
                Console.WriteLine($"{Name} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{Name} is not a palindrome");
            }

            if (IsPalinDrome.IsPalindrome(Name = "Sarah"))
            {
                Console.WriteLine($"{Name} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{Name} is not a palindrome");
            }

        }
        private static void Homework1Examples()
        {
            Bicycle2 myBike = new Bicycle2("BMX");
            MountainBike myMountain = new MountainBike();

            DownHillBike myDownhillBike = new DownHillBike();

            Console.WriteLine(myBike.WheelSpokes);
            Console.WriteLine(myMountain.WheelSpokes);

            Console.WriteLine(myDownhillBike.WheelSpokes);

            myMountain.MyMountainColor();
            myDownhillBike.MyMountainColor();


        }
        private static void Homework1()
        {
            //implement code here
            Console.WriteLine("This is Homework1");
            Bicycle myBicycle = new Bicycle();
            Bicycle myBicycle2 = new Bicycle("BMX");
            Tricycle myTricycle = new Tricycle();
            myBicycle.Color = "Green";
            myBicycle2.Color = "Red";
            myBicycle.Wheeltype = "Offroad";
            myBicycle.Wheeltype = "Street";
            myTricycle.Color = "Purple";
            myTricycle.Wheeltype = "Street";
            myBicycle.Pedal();
            myBicycle2.Pedal();
            myTricycle.Pedal();
            myBicycle.HandleBar();
            myBicycle2.HandleBar();
            myTricycle.HandleBar();
            myBicycle.Brake();
            myBicycle2.Brake();
            myTricycle.Brake();
            Console.WriteLine("myBicycle Sprocket Count: " + myBicycle.Sprocket);
            Console.WriteLine("myBicycle2 Sprocket Count: " + myBicycle2.Sprocket);
            Console.WriteLine("myTricycle Sprocket Count: " + myTricycle.Sprocket);

        }
        private static void Homework2()
        {
            //implement code here
            Console.WriteLine("This is Homework2");
            HelloWorld.Homework2.NaturalNumbers myNatural = new HelloWorld.Homework2.NaturalNumbers();
            HelloWorld.Homework2.School mySchool = new HelloWorld.Homework2.School();
            Console.WriteLine("Please enter a whole number:");

            string mySelection = " ";
            int wholeNum = 0;
            char grade = ' ';
            

            // Output: Int32.TryParse could not parse 'abc' to an int.
            mySelection = Console.ReadLine();
            bool parsed = Int32.TryParse(mySelection, out wholeNum);

            if (!parsed)
                Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", mySelection);
            else
            {
                 myNatural.CountMe(wholeNum);
            }
            Console.WriteLine("Please enter grade:");

            mySelection = Console.ReadLine();
            parsed = Char.TryParse(mySelection, out grade);

            if (!parsed)
                Console.WriteLine("Char.TryParse could not parse '{0}' to an character.\n", mySelection);
            else
            {
                Console.WriteLine($"Grade entered {grade} : " + mySchool.DisplayGradeWord(grade));
            }
            Console.Write("press Enter key to exit homework2...");
            Console.ReadLine();
        }
        private static void Homework3()
        {
            //implement code here
            Console.WriteLine("This is Homework3");
            Console.WriteLine("This section is for the Basic Bike Class");
            Homework3.Bicycle myDirtBike = new Homework3.Bicycle("BMX BIKE");
            myDirtBike.Seat = "Hard Plastic Seat";
            myDirtBike.Color = "Chrome";

            //Print off Properties of myDirtBike
            Console.WriteLine(myDirtBike.WheelSize);
            Console.WriteLine(myDirtBike.Color);
            Console.WriteLine(myDirtBike.Gears);
            Console.WriteLine(myDirtBike.Seat);
            //Execute the Methods for myDirtBike
            myDirtBike.Brake();
            myDirtBike.Pedal();
            myDirtBike.HandleBar();

            Console.WriteLine("This section is for the MultiGear Bike Class");
            Homework3.MultiGearBike myTenSpeed = new Homework3.MultiGearBike("EXERCISE BIKE");
            //Print off Properties of myTenSpeed
            //Note that I could not Print off the Derailer here because I marked it Protected in MultiGearBike Class
            myTenSpeed.Seat = "Cushony Seat";
            myTenSpeed.Color = "Blue";

            Console.WriteLine(myTenSpeed.WheelSize);
            Console.WriteLine(myTenSpeed.Color);
            Console.WriteLine(myTenSpeed.Gears);
            Console.WriteLine(myTenSpeed.Seat);

            //Execute the Methods for MyTenSpeed
            myTenSpeed.Brake();
            myTenSpeed.Pedal();
            myTenSpeed.HandleBar();

            Console.WriteLine("This section is for the DeluxeBike Class");
            Homework3.DeluxeBike mySuperBike = new Homework3.DeluxeBike("TOURING BIKE");

            mySuperBike.Seat = "Cushony Seat with Springs";
            mySuperBike.Color = "Aridescent";

            //Print off Properties of mySuperBike
            //Note that I could not Print off the Derailer here because I marked it Protected in MultiGearBike Class
            //Note that I marked the Horn / Headlamp / TailLamp / Water Bottle / 
            Console.WriteLine(mySuperBike.WheelSize);
            Console.WriteLine(mySuperBike.Color);
            Console.WriteLine(mySuperBike.Gears);
            Console.WriteLine(mySuperBike.Seat);


            //Execute the Methods for MySuperBike
            mySuperBike.Brake();
            mySuperBike.Pedal();
            mySuperBike.HandleBar();
        }
       
        private static void DinosaurTests()
        {
            Dinosaur dino1 = new Dinosaur();
            dino1.Size = 10;
            //       dino1.Eat();
            TRex tRex = new TRex();
            tRex.Size = 20;
            //        tRex.Eat();

            Dinosaur dino2 = new TRex();  // upcasting
                                          //       dino2.Eat();

            Dinosaur dino3 = new Pterodactyl();  // upcasting
                                                 //      dino3.Eat();

            Dinosaur dino4 = new Dinosaur();
            dino4 = (TRex)tRex;
            //          dino4.Eat();
            dino4 = (Pterodactyl)dino3;
            //           dino4.Eat();
            Dinosaur dino6 = dino3 as Pterodactyl;  // This is a way to test if the object is valid
            dino6.Sleep();

            TRex tRex3 = dino1 as TRex;
            dino1.Sleep();


            Dinosaur[] dinoArray = { dino1, tRex, dino2, dino3 };

            foreach (Dinosaur item in dinoArray)
            {
                if (item is TRex)  //Is there an object with that name
                {
                    item.Eat();
                }
                if (item is Pterodactyl)
                {
                    item.Sleep();
                }
            }
            GenericsList<Dinosaur> dinoList = new GenericsList<Dinosaur>();
            dinoList.Add(dino1);
            dinoList.Add(tRex);
            dinoList.Add(dino2);
            dinoList.Add(dino3);


        }
        private static void StringBuilderTest()
        {
            StringBuilder heading = new StringBuilder();
            StringBuilder body = new StringBuilder();
            StringBuilder footer = new StringBuilder();
            string s1 = "Type: ";
            string s2 = "Size: ";
            string s3 = "Buttons: ";
            string s4 = "Switches: ";
            string s5 = "Lights: ";
            string s6 = "Price:  ";
            string type1 = "Retail";
            string size1 = "Medium";
            int buttons = 3;
            int switches = 2;
            int lights = 1;
            DateTime now = DateTime.Now;
            decimal price = 39.00m;
            heading.AppendFormat("*****************************************************************");
            heading.AppendLine();
            heading.AppendFormat("***************************Wag Corporation*********************** Date/Time:  {0}", now);
            heading.AppendLine();
            for (int ctr = 0; ctr < 10; ctr++)
            {
                body.AppendFormat("   {0}. {1} {2}", ctr, s1, type1);
                body.AppendFormat("   {0} {1}", s2, size1);
                body.AppendFormat("   {0} {1}", s3, buttons);
                body.AppendFormat("   {0} {1}", s4, switches);
                body.AppendFormat("   {0} {1}", s5, lights);
                body.AppendFormat("   {0} {1}", s6, price);
                body.AppendLine();
            }
            footer.AppendFormat("*****************************************************************");
            footer.AppendLine();
            Console.WriteLine(heading.ToString() + body.ToString() + footer.ToString());
        }
        private static void AbstractFactoryPatternDemo()
        {
            string whatToMake = "Fishing Boat";
            AbstractBoatFactory factory = null;

            if (whatToMake.Equals("Fishing Boat"))
            {
                factory = new FishingBoatFactory();
            }
            else
            {
                factory = new PleasureBoatFactory();
            }
            // create the boat parts
            IBoatFrame boatFrame = factory.CreateBoatFrame();
            IBoatSeat boatSeat = factory.CreateBoatSeat();

            // show what we created
            Console.WriteLine(boatFrame.BoatFrameParts);
            Console.WriteLine(boatSeat.BoatSeatParts);
        }

        // Implementation in Homework4
        private static void BuilderPatternDemo()
        {
            AbstractPleasureBoat pleasureBoat = new HouseBoat(new InboardEngine(400), BoatColor.Forrest_Green);
            BoatBuilder builder = new PleasureBoatBuilder(pleasureBoat);
            BoatDirector director = new PleasureBoatDirector();
            IBoat boat = director.Build(builder);
            Console.WriteLine(boat);
        }

        // Implementation in Homework4
        private static void DecoratorPatternDemo()
        {
            IBoat myBassBoat = new Bass(new OutboardEngine(200), BoatColor.Metallic_Grey);
            Console.WriteLine(myBassBoat);

            myBassBoat = new FishFinderGear(myBassBoat);
            Console.WriteLine(myBassBoat);

            IBoat myPontoonBoat = new Pontoon(new InboardEngine(350), BoatColor.Metallic_Grey);
            Console.WriteLine(myPontoonBoat);

            myPontoonBoat = new RefrigerationUnit(myPontoonBoat);
            Console.WriteLine(myPontoonBoat);

            IBoat myHouseBoat = new HouseBoat(new InboardEngine(550), BoatColor.Sandstone_Brown);
            Console.WriteLine(myHouseBoat);

            myHouseBoat = new EntertainmentCenter(myHouseBoat);
            Console.WriteLine(myHouseBoat);
        }

        // Implementation in Homework4
        private static void AdapterPatternDemo()
        {
            IList<IEngine> engines = new List<IEngine>();
            engines.Add(new InboardEngine(450));
            engines.Add(new InboardEngine(600));
            engines.Add(new OutboardEngine(250));
            engines.Add(new OutboardEngine(350));

            UltraEngine ultraEngine = new UltraEngine(1000);
            engines.Add(new UltraEngineAdapter(ultraEngine));

            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);
            }
        }

        // Implementation in Homework4
        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
        }

        // Implementation in Homework4
        private static void FacadePatternDemo()
        {
            BoatFacade facade = new BoatFacade();
            facade.PrepareForSale(new HouseBoat(new InboardEngine(500), BoatColor.Metallic_Grey));
        }

        // Implementation in Homework5
        private static void Homework5()
        {
           Pistols myPistol = new Pistols("Beretta", 45);
           Pistols.ShootPistol thePistol = myPistol.ShootAPistol;
           thePistol(" I shot a " + myPistol.PistolBrand + " at a caliber of  " + myPistol.PistolCaliber);
           Pistols mySecond = new Pistols();

            Pistols morePistols = new Pistols(45);
            Pistols.ShootPistol somePistols, policePistol, shotGunPistol;

            policePistol = morePistols.PolicePistol;
            policePistol("Glock");

            shotGunPistol = morePistols.ShotGunPistol;
            shotGunPistol("The Judge");

            somePistols = policePistol + shotGunPistol;
            somePistols("Cool");
        }

        private static void Homework6()
        {
            TryCatchException tryCatch = new TryCatchException();
            ArrayListPractice arrayPractice = new ArrayListPractice();
        }
        private static void Homework7()
        {
            AsyncExercise myExercise = new AsyncExercise();
            myExercise.MyMethodAsync();
        }
        // Advanced C Sharp Implementation
        private static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            Hats.TryOn theHat = myHat.TryOnHat;
            theHat("I tried on a " + myHat.HatType + "hat that was size " + myHat.HatSize);

            Hats mySecond = new Hats();
        }
        // Advanced C Sharp Implementation
        private static void MultiDelegateSample()
        {
            Hats moreHats = new Hats(7);
            Hats.TryOn someHats, niceHat, sadHat;

            niceHat = moreHats.FindLuckHat;
            niceHat("Top");

            sadHat = moreHats.FindUglyHat;
            sadHat("Dunce");

            someHats = niceHat + sadHat;
            someHats("Cowboy");
        }
        // Advanced C Sharp Implementation
        private static void EventSample()
        {
            Coats myCoat = new Coats(); //Instatiate the class
            string result = myCoat.MyResult; // Get result from property
            Console.WriteLine(result);
        }
        private static void SimpleTaskExample()
        {
            Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression
            Task task = new Task(() => Console.WriteLine("Hello from task."));
            //Define a run with Task
            //Task task = Task.Run(() => Console.WriteLine("Hello from task."));

            // Start the task
            task.Start();
            //Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            task.Wait();
        }

        private async static void MyAsyncExample()
        {
            AsyncUtility myUtility = new AsyncUtility();
            string myWord = await myUtility.BottlesOfBeerSongAsync();
            Console.WriteLine(myWord);
            int myResult = await myUtility.AccessTheWebAsync();
            Console.WriteLine(myResult);
        }

        private static void MyLinqExample()
        {
            string[] names = { "Tom", "Don", "Harry", "Mary", "Jay" };

            IEnumerable<string> query = names
            .Where(n => n.Contains("a"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

            foreach (string name in query) Console.WriteLine(name);

            CollectionSample();
        }

        private static void CollectionSample()
        {
            CollectionExamples mySample = new CollectionExamples();

            //mySample.MyArrayListExample();

            mySample.MyListExample2();

        }

        private static void ExceptionSample()
        {
            ExceptionExamples examples = new ExceptionExamples();
            //examples.MyException();

            //examples.MySecondExample();
            examples.MyThirdExample();
        }
        private static void LambdaSample()
        {
            LambdaExamples myLamb = new LambdaExamples();
            Console.WriteLine(myLamb.MyLambdaOne(5));
        }
        private static void ThreadingSample()
        {
            Thread thread = new Thread(DelegateSample);
            thread.Start();

            MultiDelegateSample();
        }
        private static void ThreadingSample2()
        {
            // Calling constructor with value using Thread two ways
            ThreadingExample myExample = new ThreadingExample();
            //Thread thread = new Thread(() => myExample.SimpleMethod(100));
            //thread.Start();

            // or the older implementation
            Thread secondThread = new Thread(myExample.DifferentMethod);
            secondThread.Start("I see");
        }

        // The callback method must match the signature of the callback delegate
        public static void ResultCallback(int lineCount)
        {
            Console.WriteLine(
                "Independent task printed {0} lines.", lineCount);
        }

        private static void ThreadingReturnSample()
        {
            ThreadWithState tws = new ThreadWithState("This report displays the number {0}.", 42,
                new ExampleCallback(ResultCallback));
            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            Console.WriteLine("Main thread does some work, then waits.");
            t.Join();
        }

        private static void AnonymousTypeExample()
        {
            CollectionExamples mySample = new CollectionExamples();
            var myDinos =
                from dino in mySample.MyListExample2()
                select new { dino.Size, dino.Teeth, dino.Skin };

            foreach (var v in myDinos)
            {
                Console.WriteLine("Size = {0},Teeth = {1},Skin = {2} ", v.Size, v.Teeth, v.Skin);
            }
        }
    }
}





