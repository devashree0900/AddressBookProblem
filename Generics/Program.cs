using Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Practise problem in class
             
                Console.WriteLine("Welcome to Generic Demo:");
                int[] intArray = {1, 2 ,3 };
                char[] charArray = {'a','b','c'};
                double[] doubleArray = { 1.1, 2.2,3.3 };
                //Program.PrintArray<double>(doubleArray);
                Program.printArray(intArray);
                Program.printArray(doubleArray);
                Program.printArray(charArray);

            }

            public static void printArray(int[] intArray)
            {
                foreach(int item in intArray)
                {
                    Console.WriteLine("Printing item: "+ item);
                }
            }

            public static void printArray(double[] doubleArray)
            {
                foreach (double item in doubleArray)
                {
                    Console.WriteLine("Printing item: " + item);
                }
            }

            public static void printArray(char[] charArray)
            {
                foreach (char item in charArray)
                {
                    Console.WriteLine("Printing item: " + item);
                }
            }
            public static void PrintArray<T>(T[] array)
            {
                foreach (var item in array)
                {
                    Console.WriteLine("Printing item in array: "+ item);
                }
            }

            */

            //Assignment Problem
            FindMax obj = new FindMax();
            //Console.WriteLine(obj.MaximumNumber(1, 2, 3));
            //Console.WriteLine(obj.MaximumNumber("abc", "nbgdhy", "hdbhjjhbejhfc"));
            //Console.WriteLine(obj.MaximumNumber(1.2, 5.6, 7.2));

            //Console.WriteLine(FindMax.maxUsingGeneric(1,2,3));
            Console.WriteLine(FindMax.maxUsingGeneric(1.1, 20.2, 33.66));
            Console.WriteLine(FindMax.maxUsingGeneric("abc", "abcde", "abcdef"));
        }
    }
}