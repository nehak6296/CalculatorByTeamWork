using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator");

            decimal result = 0;

            int action = 0;

            while (0 >= action || action >= 6)
            {
<<<<<<< HEAD
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        Console.WriteLine(result);
=======
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");

                Console.WriteLine("Press 2 for Subtraction");

                Console.WriteLine("Press 3 for Division");

                Console.WriteLine("Press 4 for Multiplication");

                Console.WriteLine("Press 5 for Modulation");

                Console.WriteLine("Enter your choice from 1 to 5:");
                action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int input_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int input_2 = Convert.ToInt32(Console.ReadLine());

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
                    case 5:
                        {
                            result = Modulation(input_1, input_2);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong choice!! try again");
>>>>>>> 3463c66931bff2e975533c368960472230553ef7
                        break;
                }

                if (0 < action && action < 6)
                {
                    Console.WriteLine("The result is {0}", result);
                }
            }

            MoreMethods.Inputs();

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

        //Modulation 
        public static decimal Modulation(int input_1, int input_2)
        {
            decimal result = Convert.ToDecimal(input_1) % input_2;
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

        public static void Inputs()
        {
            Console.WriteLine("Calculation Complete Finished");
        }

    }

}
