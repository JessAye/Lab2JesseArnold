using System.Threading.Channels;
using System;
using System.Linq;
using System.Collections.Generic;
namespace Program
{
    class Lab2
    {
        static void Main(string[] args)
        {
            
            var userSelection = 0;
            Console.WriteLine("Welcome\nWhat would you like to do");
            Console.WriteLine("1 - Add two numbers\n" +
                              "2 - Gets multiplications of a number\n" +
                              "3- Show datatype sizes\n" +
                              "4- Calculator");
               userSelection = Int32.Parse(Console.ReadLine()!);
            switch (userSelection){
                case 1:
                    AddTwoNums();
                    break;
                case 2:
                    Multiply();
                    break;
                case 3:
                    TypeSizes();
                    break;
            }
            
           
        }

        static void AddTwoNums()
        {
            var firstNumber = 0;
            var secondNumber = 0;


            Console.WriteLine("Enter 2 Numbers and they will be added together");
            Console.WriteLine("First Number?: ");
            firstNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine("Second Number?: ");
            secondNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Format("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber));
        }

        static void Multiply()
        {
            var firstNumber = 0;
            var secondNumber = 0;


            Console.WriteLine("Enter a number and how many multiples you want");
            Console.WriteLine("Number?: ");
            firstNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine("How many multiples: ");
            secondNumber = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i <= secondNumber; i++)
            {
                Console.WriteLine(string.Format("{0} * {1} = {2}",firstNumber, i, firstNumber*i));
            }
        }

        static void TypeSizes()
        {
            string[] dataMax = new[] { sbyte.MaxValue.ToString(),byte.MaxValue.ToString(),short.MaxValue.ToString(),ushort.MaxValue.ToString(),int.MaxValue.ToString(),uint.MaxValue.ToString(),long.MaxValue.ToString(),ulong.MaxValue.ToString(),float.MaxValue.ToString(),double.MaxValue.ToString(),decimal.MaxValue.ToString() };
            string[] dataMin = new[] { sbyte.MinValue.ToString(),byte.MinValue.ToString(),short.MinValue.ToString(),ushort.MinValue.ToString(),int.MinValue.ToString(),uint.MinValue.ToString(),long.MinValue.ToString(),ulong.MinValue.ToString(),float.MinValue.ToString(),double.MinValue.ToString(),decimal.MinValue.ToString() };
            int[] datasize = new[] { sizeof(sbyte),sizeof(byte),sizeof(short),sizeof(ushort),sizeof(int), sizeof(uint),sizeof(long),sizeof(ulong),sizeof(float),sizeof(double),sizeof(decimal) };
            string[] datatype = new[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float","double","decimal" };
            Console.WriteLine("----------------------------------------------------------------------------\n" +
                              "Type   Byte(s) of memory                 min                           max \n" +
                              "----------------------------------------------------------------------------\n");
            for (int i = 0; i <datasize.Length ; i++)

            {
                Console.WriteLine("{0,-10}{1,3}{2,30}{3,30}  ", datatype[i],datasize[i],dataMin[i],dataMax[i]);

            };
                
        }
        }
        
    }
