using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorldCore
{
    public class Program
    {
        private int result;
        
        public int Result 
        {
            get { return result; }
            set { result = value; }
        }

        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        public int AddTwoNumbers(int number1, int number2) 
        {

            return number1 + number2;
        }

        public int MultiplyTwoNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        public int DivideTwoNumbers(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (DivideByZeroException) {
                return 0;
            }
        }

        public int SubstractTwoNumbers(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
