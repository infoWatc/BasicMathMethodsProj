/*
    Various methods of processing numbers 
    Manipulation of arrays and type conversions
*/
using System;

namespace BasicMathMethodsProj
{
    class MathObjects
    {
        private dynamic numOne= 0;
        private dynamic NumTwo = 0;
        public MathObjects(dynamic num1, dynamic num2)
        {
            numOne = num1;
            NumTwo = num2;
        }

        public dynamic NumOne
        {
           get
            {
                return numOne;
            }
            set
            {
                numOne = value;
            }
        }
        public string AnyMath(char symb)
        {
            if (symb == '+')
            {
                return $"\t{NumOne} + {NumTwo} = {(NumOne + NumTwo).ToString()}";
            }
            else if (symb == '-')
            {
                return $"\t{NumOne} - {NumTwo} = {(NumOne - NumTwo).ToString()}";
            }
            else if (symb == '*')
            {
                return $"\t{NumOne} x {NumTwo} = {(NumOne * NumTwo).ToString()}";
            }
            else if (symb == '/')
            {
                return $"\t{NumOne} / {NumTwo} = {(NumOne / NumTwo).ToString()}";
            }
            else if (symb == '%')
            {
                return $"\t{NumOne} % {NumTwo} = {(NumOne % NumTwo).ToString()}";
            }
            else
                return "not a math value";
        }

    }
    class Program
    {
        static void ToLine(string text) => Console.WriteLine($"{text}");
        /*
            static string Add(dynamic numOne, dynamic numTwo)
            {
                return $"{numOne} + {numTwo} = {(numOne + numTwo).ToString()}";
            }
        */
        
        static string Add(dynamic numOne, dynamic numTwo) => $"\t{numOne} + {numTwo} = {(numOne + numTwo).ToString()}";

        static string Subtract(dynamic numOne, dynamic numTwo) => $"\t{numOne} - {numTwo} = {(numOne - numTwo).ToString()}";

        static string Multiply(dynamic numOne, dynamic numTwo) => $"\t{numOne} + {numTwo} = {(numOne + numTwo).ToString()}";

        static string Divide(dynamic numOne, dynamic numTwo) => $"\t{numOne} / {numTwo} = {(numOne / numTwo).ToString()}";

        static string Modulus(dynamic numOne, dynamic numTwo) => $"\t{numOne} % {numTwo} = {(numOne % numTwo).ToString()}";

        public static string AnyMath(char symb, dynamic numOne, dynamic numTwo)
        {
            if (symb == '+')
            {
                return $"\t{numOne} + {numTwo} = {(numOne + numTwo).ToString()}";
            }
            else if (symb == '-')
            {
                return $"\t{numOne} - {numTwo} = {(numOne - numTwo).ToString()}";
            }
            else if (symb == '*')
            {
                return $"\t{numOne} x {numTwo} = {(numOne * numTwo).ToString()}";
            }
            else if (symb == '/')
            {
                return $"\t{numOne} / {numTwo} = {(numOne / numTwo).ToString()}";
            }
            else if (symb == '%')
            {
                return $"\t{numOne} % {numTwo} = {(numOne % numTwo).ToString()}";
            }
            else
                return "not a math value";
        }

        public static string[] Swap(ref string[] numbers)
        {
            string swapValue = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = swapValue;
            return numbers;                       
        }

        public static void Main(string[] args)
        {

            int intMax = int.MaxValue;
            long longMax = long.MaxValue;
            Console.Write("Enter the first number\t >");
            double dubNum1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number\t >");
            double dubNum2 = Convert.ToDouble(Console.ReadLine());
            int integerNum = 33;
            long longNum = 49;

            // Call to Methods
            ToLine("Using dynamic methods\n");
            ToLine(Add(35, 32));
            ToLine(Add(intMax, -1));
            ToLine(Add(longMax, -1));
            ToLine(Subtract(3.898, 5.34));
            ToLine(Multiply(8, 3));
            ToLine(Divide(9.5, 3));
            ToLine(Modulus(9.5, 3));

            ToLine(Add(integerNum, longNum));

            ToLine("\nOne Method using dynamic\n");
            // Call one method & Char Option
            ToLine(AnyMath('/', 75, 25));
            ToLine(AnyMath('%', 10, 3));
            ToLine(AnyMath('+', 28, 2));
            ToLine(AnyMath('-', 15, 3));
            ToLine(AnyMath('*', 3, 2));

            // objects
            ToLine("\nOBJECTS");
            MathObjects doSomeMath = new MathObjects(longNum, integerNum);
            ToLine(doSomeMath.AnyMath('+'));
            ToLine(doSomeMath.AnyMath('-'));
            ToLine(doSomeMath.AnyMath('*'));
            ToLine(doSomeMath.AnyMath('/'));
            ToLine(doSomeMath.AnyMath('%'));

            // Array swap method
            double num1 = dubNum1;
            double num2 = dubNum2;
            string[] numbers = { num1.ToString(), num2.ToString() };            
            string firstWas = numbers[0];
            string secondWas = numbers[1];
            ToLine($"\nArray Swap\n\tNew Array\n\t\tnumbers[0]:{numbers[0]}, numbers[1]:{numbers[1]}");
            Swap(ref numbers);
            ToLine($"\n\tFirst number was {firstWas}, now {numbers[0]}, second number was {secondWas}, now {numbers[1]}");
            ToLine($"\n\tSwap Called\n\t\tnumbers[0]:{numbers[0]}, numbers[1]:{numbers[1]}");

        }
    }
}
