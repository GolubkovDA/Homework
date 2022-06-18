using System;

namespace Calculator { 
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            double userInput;

            Console.WriteLine("Choose operation: \n1 - add \n2 - subtract \n3 - multiply \n4 - division \n5 - exponentiation \n6 - Factorial \n7 - Close program  ");
            var validation = double.TryParse(Console.ReadLine(), out userInput);
            switch (userInput)
            {
                case 1:
                    AddTwoNumbers();
                    break;
                case 2:
                    SubtractTwoNumbers();
                    break;
                case 3:
                    MultiplyTwoNumbers();
                    break;
                case 4:
                    DivisionTwoNumbers();
                    break;
                case 5:
                    ExponentiationTwoNumbers();
                    break;
                case 6:
                    FactorialTwoNumbers();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Invalid value entered");
                    MainMenu();
                    break;
            }
            
        }
        static void AddTwoNumbers () 
        {
            double firstValue;
            double secondValue;

            Console.WriteLine("Enter first number");
            var validationFirstValue = double.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter second number");
            var validationSecondValue = double.TryParse(Console.ReadLine(), out secondValue);

            if ( validationFirstValue == true && validationSecondValue == true)
            {
                Console.WriteLine($"Result : {firstValue + secondValue}");
                MainMenu();
                return;
            }
            else
                Console.WriteLine("Invalid value entered");
                MainMenu();
                return;
        }
        static void SubtractTwoNumbers()
        {
            double firstValue;
            double secondValue;

            Console.WriteLine("Enter first number");
            var validationFirstValue = double.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter second number");
            var validationSecondValue = double.TryParse(Console.ReadLine(), out secondValue);

            if (validationFirstValue == true && validationSecondValue == true)
            {
                Console.WriteLine($"Result : {firstValue - secondValue}");
                MainMenu();
                return;
            }
            else
                Console.WriteLine("Invalid value entered");
            MainMenu();
            return;
        }
        static void MultiplyTwoNumbers()
        {
            double firstValue;
            double secondValue;

            Console.WriteLine("Enter first number");
            var validationFirstValue = double.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter second number");
            var validationSecondValue = double.TryParse(Console.ReadLine(), out secondValue);

            if (validationFirstValue == true && validationSecondValue == true)
            {
                Console.WriteLine($"Result : {firstValue * secondValue}");
                MainMenu();
                return;
            }
            else
                Console.WriteLine("Invalid value entered");
            MainMenu();
            return;
        }
        static void DivisionTwoNumbers()
        {
            double firstValue;
            double secondValue;

            Console.WriteLine("Enter first number (dividend)");
            var validationFirstValue = double.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter second number (divisor)");
            var validationSecondValue = double.TryParse(Console.ReadLine(), out secondValue);

            if (validationFirstValue == true && validationSecondValue == true)
            {
                if (secondValue == 0)
                {
                    Console.WriteLine($"divisor cannot equal 0");
                    MainMenu();
                    return;
                }
                else
                    Console.WriteLine($"Result: {firstValue / secondValue}");
                    MainMenu();
                     return;
            }
            else
                Console.WriteLine("Invalid value entered");
            MainMenu();
            return;
        }    
        static void ExponentiationTwoNumbers()
        {
            double firstValue;
            double secondValue;

            Console.WriteLine("Enter number ");
            var validationFirstValue = double.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter degree");
            var validationSecondValue = double.TryParse(Console.ReadLine(), out secondValue);

            if (validationFirstValue == true && validationSecondValue == true)
            {
            Console.WriteLine($"Result:{Math.Pow(firstValue, secondValue)}");
            MainMenu();
            return;
            }
            else
                Console.WriteLine("Invalid value entered");
            MainMenu();
            return;
        }
        static void FactorialTwoNumbers()
        {
            ulong firstValue;
            Console.WriteLine("Enter number ");
            var validationFirstValue = ulong.TryParse(Console.ReadLine(), out firstValue);

            if (validationFirstValue == true && firstValue > 0)
            {
                Console.WriteLine($"Result:{GetFactirial(firstValue)}");
                MainMenu();
                return;

            }
            else
                Console.WriteLine("Invalid value entered");
            MainMenu();
            return;
        }
        static ulong GetFactirial (ulong number)
        {
            ulong factorial = 1;
            for (ulong i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
