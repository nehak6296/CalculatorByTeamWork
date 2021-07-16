using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator");

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");

            Console.WriteLine("Press 2 for Subtraction");

            Console.WriteLine("Press 3 for Division");

            Console.WriteLine("Press 4 for Multiplication");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            decimal result = 0;
            switch (action)
            {
                case 1:

                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:

                    {
                        result = MoreMethods.Subtraction(input_1, input_2);
                        break;
                    }
                case 3:

                    {
                        result = Division(input_1, input_2);

                        break;
                    }

                case 4:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication 
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Division  
        public static decimal Division(int input_1, int input_2)
        {
            decimal result = Convert.ToDecimal(input_1) / input_2;
            return result;
        }
    }

    public class MoreMethods
    {
        public static int Subtraction(int input_1, int input_2)
        {
            int result = Math.Abs(input_1 - input_2);
            return result;
        }

    }

}
