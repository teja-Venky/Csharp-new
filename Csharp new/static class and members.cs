using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_new
{
    internal class static_class_and_members
    {
        //        public static class TemperatureConverter
        //        {
        //            public static double CelsiusToFahrenheit(string temperatureCelsius) =>
        //                double.Parse(temperatureCelsius) * 9 / 5 + 32;

        //            public static double FahrenheitToCelsius(string temperatureFahrenheit) =>
        //                (double.Parse(temperatureFahrenheit) - 32) * 5 / 9;
        //        }

        //        class TestTemperatureConverter
        //        {
        //            static void Main()
        //            {
        //                Console.WriteLine("Please select the convertor direction");
        //                Console.WriteLine("1. From Celsius to Fahrenheit.");
        //                Console.WriteLine("2. From Fahrenheit to Celsius.");
        //                Console.Write(":");

        //                string? selection = Console.ReadLine();

        //                switch (selection)
        //                {
        //                    case "1":
        //                        Console.Write("Please enter the Celsius temperature: ");
        //                        var f = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
        //                        Console.WriteLine($"Temperature in Fahrenheit: {f:F2}");
        //                        break;

        //                    case "2":
        //                        Console.Write("Please enter the Fahrenheit temperature: ");
        //                        var c = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
        //                        Console.WriteLine($"Temperature in Celsius: {c:F2}");
        //                        break;

        //                    default:
        //                        Console.WriteLine("Please select a convertor.");
        //                        break;
        //                }

        //                // Keep the console window open in debug mode.
        //                Console.WriteLine("Press any key to exit.");
        //                Console.ReadKey();
        //            }
        //        }
        //        /* Example Output:
        //            Please select the convertor direction
        //            1. From Celsius to Fahrenheit.
        //            2. From Fahrenheit to Celsius.
        //            :2
        //            Please enter the Fahrenheit temperature: 20
        //            Temperature in Celsius: -6.67
        //            Press any key to exit.
        //         */


        //own code: 

        class Program
        {
            static void Main()
            {
                bool continueProgram = true;

                do
                {
                    Console.WriteLine("\nTemperature Converter");
                    Console.WriteLine("1. Celsius to Fahrenheit");
                    Console.WriteLine("2. Fahrenheit to Celsius");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose an option: ");

                    string? choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                        case "2":
                            Console.Write("Enter temperature value: ");

                            if (double.TryParse(Console.ReadLine(), out double temp))
                            {
                                double result = choice switch
                                {
                                    "1" => temp * 9 / 5 + 32,
                                    "2" => (temp - 32) * 5 / 9,
                                    _ => 0
                                };

                                string unit = choice == "1" ? "°F" : "°C";
                                Console.WriteLine($"Converted Temperature: {result:F2} {unit}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid temperature input.");
                            }
                            break;

                        case "3":
                            continueProgram = false;
                            break;

                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }

                } while (continueProgram);

                Console.WriteLine("Program ended.");
            }
        }
    }
}
