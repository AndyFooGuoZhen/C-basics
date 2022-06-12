using System;

namespace T1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Print();
            //readInput();
            //printArr();
            methodtest("Foo");
            exceptions();
        }

        static void Print()
        {
            string name = "Andy";
            int number = 10;
            bool state = true;
            char character = 'a';
            double grades = 4.4;

            Console.WriteLine("Wassup " + name);
            Console.WriteLine("Length of string is " + name.Length);
            Console.WriteLine("Second letter of string is " + name[1]);

            //All mathematical function is the same as java
            Console.WriteLine(Math.Pow(number, 2));

        }

        static void readInput()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
        }


        static void printArr()
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(arr.Length);

            string[] arrStr = new string[5];

            //2d arr is different form java convention
            int[,] arr2d = new int[2, 2];

        }

        static void methodtest(string name)
        {
            Console.WriteLine("The name you have just passed to the method is " + name);
        }

        //if else statement the same as in java
        //switch statement, while, and for is the same
        //try , catch exceptions are the same
        static void exceptions()
        {
            try
            {
                int number = 1;
                int number2 = 0;

                Console.Write(number / number2);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}

