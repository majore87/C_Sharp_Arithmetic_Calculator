using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {   
                //Variable for loop break

                bool keepLooping = true;

                // User prompt first number or exit

                Console.Write("Prompt first number: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    while (keepLooping)
                    {
                        // User choose operation(+-/*^) or exit

                        double number1 = double.Parse(entry);
                        Console.WriteLine("\nChoose operation:\n1.+\n2.-\n3./\n4.*\n5.^");
                        var operation = Console.ReadLine();

                        if (operation.ToLower() == "quit")
                        {
                            Environment.Exit(0);
                        }

                        else if (operation == "+" || operation == "1")
                        {
                            // User prompt second number or exit
                            while (keepLooping)
                            {
                                Console.Write("\nPrompt second number: ");
                                var entry2 = Console.ReadLine();

                                if (entry2.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }

                                // Program print result of an addition. User starts from the beginning.

                                try
                                {
                                    double number2 = double.Parse(entry2);
                                    double addition = number1 + number2;
                                    Console.WriteLine("Result: " + addition);
                                    keepLooping = false;
                                    break;

                                }

                                // Catch exception if User prompt any character besides the number

                                catch (FormatException)
                                {
                                    Console.WriteLine("\nThat is not valid input");
                                }
                            }


                        }


                        else if (operation == "-" || operation == "2")
                        {
                            // User prompt second number or exit
                            while (keepLooping)
                            {
                                Console.Write("\nPrompt second number: ");
                                var entry2 = Console.ReadLine();

                                if (entry2.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }

                                // Program print result of an subtraction. User starts from the beginning.

                                try
                                {
                                    double number2 = double.Parse(entry2);
                                    double subtraction = number1 - number2;
                                    Console.WriteLine("Result: " + subtraction);
                                    keepLooping = false;
                                    break;

                                }

                                // Catch exception if User prompt any character besides the number

                                catch (FormatException)
                                {
                                    Console.WriteLine("\nThat is not valid input");
                                }
                            }


                        }

                        // Loop of choosing the operation in case of prompt mistake  


                        else if (operation == "/" || operation == "3")
                        {
                            // User prompt second number or exit
                            while (keepLooping)
                            {
                                Console.Write("\nPrompt second number: ");
                                var entry2 = Console.ReadLine();

                                if (entry2.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }

                                // Program print result of an division. User starts from the beginning.

                                try
                                {
                                    double number2 = double.Parse(entry2);
                                    double division = number1 / number2;
                                    Console.WriteLine("Result: " + division);
                                    keepLooping = false;
                                    break;

                                }

                                // Catch exception if User prompt any character besides the number

                                catch (FormatException)
                                {
                                    Console.WriteLine("\nThat is not valid input");
                                }
                            }


                        }

                        else if (operation == "*" || operation == "4")
                        {
                            // User prompt second number or exit
                            while (keepLooping)
                            {
                                Console.Write("\nPrompt second number: ");
                                var entry2 = Console.ReadLine();

                                if (entry2.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }

                                // Program print result of an multiplication. User starts from the beginning.

                                try
                                {
                                    double number2 = double.Parse(entry2);
                                    double multiplication = number1 * number2;
                                    Console.WriteLine("Result: " + multiplication);
                                    keepLooping = false;
                                    break;

                                }

                                // Catch exception if User prompt any character besides the number

                                catch (FormatException)
                                {
                                    Console.WriteLine("\nThat is not valid input");
                                }
                            }


                        }

                        else if (operation == "^" || operation == "5")
                        {
                            // User prompt second number or exit
                            while (keepLooping)
                            {
                                Console.Write("\nPrompt the exponent: ");
                                var entry2 = Console.ReadLine();

                                if (entry2.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }

                                // Program print result of an exponentiation. User starts from the beginning.

                                try
                                {
                                    double number2 = double.Parse(entry2);
                                    double exponentiation = Math.Pow(number1, number2);
                                    Console.WriteLine("Result: " + exponentiation);
                                    keepLooping = false;
                                    break;

                                }

                                // Catch exception if User prompt any character besides the number

                                catch (FormatException)
                                {
                                    Console.WriteLine("\nThat is not valid input");
                                }
                            }


                        }

                        else
                        {
                            Console.WriteLine("\nPlease select the operation");
                        }


                    }


                }

                // Catch exception if User prompt any character besides the number

                catch (FormatException)
                {

                    Console.WriteLine("\nThat is not valid input");
                    continue;
                }
            }
                                   
                          
                               
                                   
        }
    }
}
