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
                // User prompt first number or exit

                Console.Write("\nPrompt first number: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    while (true)
                    {
                        // User choose operation or exit

                        double number1 = double.Parse(entry);
                        Console.WriteLine("\nChoose operation:\n1.+\n2.-\n3./\n4.*\n5.^");
                        var operation = Console.ReadLine();

                        if (operation.ToLower() == "quit")
                        {
                            Environment.Exit(0);
                        }

                        // User prompt second number or exit

                        else if (operation == "+" || operation == "1")
                        {
                            Console.WriteLine("\nPrompt second number: ");
                            var entry2 = Console.ReadLine();
                                                        
                            if (entry2.ToLower() == "quit")
                            {
                                break;
                            }

                            // Program print result of an addition. User starts from the beginning.
                            try
                            {
                                double number2 = double.Parse(entry2);
                                double addition = number1 + number2;
                                Console.WriteLine("Result: " + addition);
                                break;
                                
                            }

                            // Catch exception if User prompt any character besides the number
                            catch (FormatException)
                            {
                                Console.WriteLine("\nThat is not valid input");
                            }
                                                        
                            
                        }

                        // Loop of choosing the operation in case of prompt mistake  
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
