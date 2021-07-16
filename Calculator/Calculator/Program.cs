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

            Console.WriteLine("Press 2 for Division");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:

                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
              case 2:

                    { 
                        result = Division(input_1, input_2);

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
    }
       

        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }

    }
