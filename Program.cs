using System;
using System.Text;

namespace Calculator
{
    class Calc{
        static void Main(string[] args)
        {   
            string value;
            do
            {
                int res;

                    Console.WriteLine("Enter first number:" );
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Method to perform (/, *, +. -): " );
                    string symbol = Console.ReadLine();

                switch (symbol)
                {
                    //Addition
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("The Sum is:" + res);
                            if (res % 2 == 0)
                            {
                            Console.WriteLine("It's an Odd number");
                            }else{
                            Console.WriteLine("It's an Even number");
                            }
                        break;

                    //Subtraction    
                    case "-":
                        res = num1 + num2;
                        Console.WriteLine("The Difference is:" + res);
                        if (res % 2 == 0)
                            {
                            Console.WriteLine("It's an Odd number");
                            }else{
                            Console.WriteLine("It's an Even number");
                            }
                        break;

                    //Multiplication
                    case "*":
                        res = num1 + num2;
                        Console.WriteLine("The Product is:" + res);
                        if (res % 2 == 0)
                            {
                            Console.WriteLine("It's an Odd number");
                            }else{
                            Console.WriteLine("It's an Even number");
                            }
                        break;

                    //Division
                    case "/":
                        res = num1 + num2;
                        Console.WriteLine("The Quotient is:" + res);
                        if (res % 2 == 0)
                            {
                            Console.WriteLine("It's an Odd number");
                            }else{
                            Console.WriteLine("It's an Even number");
                            }
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Would you like to continue? (Y/N):");
                value = Console.ReadLine();
            
            }
            while (value == "y" || value == "Y");
        }
    }
}