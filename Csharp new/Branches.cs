//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// Branches and Selection Statements in C#

//namespace Csharp_new
//{
//    internal class Branches
//    {
       // static void Main(string[] args)
       // {
       //     //program1: if Statement in C#
            //int a = 5;
            //int b = 6;
            //int c = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10.");
            //In this the condition gets satisfied and approved(TRUE) and prints the given statement.
            // if i use value c in place of b in a condition then the console tab will be empty because condition is deniled(FALSE).

            //program1a:
            //DisplayMeasurement(45);  // Output: The measurement value is 45
            //DisplayMeasurement(-3);  // Output: Warning: not acceptable value! The measurement value is -3

            //void DisplayMeasurement(double value)
            //{
            //    if (value < 0 || value > 100)
            //    {
            //        Console.Write("Warning: not acceptable value! ");
            //    }

            //    Console.WriteLine($"The measurement value is {value}");
            //}


            //program2: if-else Statement in C#
            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10"); //condition is satisfied then this print statement gets executed.
            //else
            //    Console.WriteLine("The answer is not greater than 10"); //condition is not satisfied then this print statement gets executed.


            //Program2a: 
            //DisplayWeatherReport(15.0);  // Output: Cold.      //method
            //DisplayWeatherReport(24.0);  // Output: Perfect!    //method

            //void DisplayWeatherReport(double tempInCelsius)
            //{
            //    if (tempInCelsius < 20.0)
            //    {
            //        Console.WriteLine("Cold.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Perfect!");
            //    }
            //}

            //program3:if-else complex program using (== ,&& ,>) AND operator.
            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) && (a == b))   //FALSE
            //{
            //    Console.WriteLine("The answer is greater than 10");       // print for COndition TRUE
            //    Console.WriteLine("And the first number is equal to the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not equal to the second");    //prints if condition is FALSE
            //}


            //Program4: if-else condition using OR operator 

            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) || (a == b))    //TRUE
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("Or the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("And the first number is not greater than the second");
            //}

            //Program5: Explore If();  //this Explore If(); is an existing code method. the code is called as ExploreIf() from the top of the program till last line.
            //ExploreIf(); //if im not using this method then the explore() code does not get executed.

            //void ExploreIf()
            //{
            //    int a = 5;
            //    int b = 3;
            //    if (a + b > 10)
            //    {
            //        Console.WriteLine("The answer is greater than 10");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The answer is not greater than 10");
            //    }

            //    int c = 4;
            //    if ((a + b + c > 10) && (a > b))  //TRUE
            //    {
            //        Console.WriteLine("The answer is greater than 10");
            //        Console.WriteLine("And the first number is greater than the second");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The answer is not greater than 10");
            //        Console.WriteLine("Or the first number is not greater than the second");
            //    }

            //    if ((a + b + c > 10) || (a > b))    //TRUE
            //    {
            //        Console.WriteLine("The answer is greater than 10");
            //        Console.WriteLine("Or the first number is greater than the second");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The answer is not greater than 10");
            //        Console.WriteLine("And the first number is not greater than the second");
            //    }
            // }

            //Program6: if statement to check multiple conditions

            //DisplayCharacter('f');  // Output: A lowercase letter: f
            //DisplayCharacter('R');  // Output: An uppercase letter: R
            //DisplayCharacter('8');  // Output: A digit: 8
            //DisplayCharacter(',');  // Output: Not alphanumeric character: ,

            //void DisplayCharacter(char ch)
            //{
            //    if (char.IsUpper(ch))
            //    {
            //        Console.WriteLine($"An uppercase letter: {ch}");
            //    }
            //    else if (char.IsLower(ch))
            //    {
            //        Console.WriteLine($"A lowercase letter: {ch}");
            //    }
            //    else if (char.IsDigit(ch))
            //    {
            //        Console.WriteLine($"A digit: {ch}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Not alphanumeric character: {ch}");
            //    }

            //Program7: Switch Statements in C#

            //DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
            //DisplayMeasurement(5);  // Output: Measured value is 5.
            //DisplayMeasurement(30);  // Output: Measured value is 30; too high.
            //DisplayMeasurement(double.NaN);  // Output: Failed measurement.

            //void DisplayMeasurement(double measurement)
            //{
            //    switch (measurement)
            //    {
            //        case < 0.0:
            //            Console.WriteLine($"Measured value is {measurement}; too low.");
            //            break;

            //        case > 15.0:
            //            Console.WriteLine($"Measured value is {measurement}; too high.");
            //            break;

            //        case double.NaN:
            //            Console.WriteLine("Failed measurement.");
            //            break;

            //        default:
            //            Console.WriteLine($"Measured value is {measurement}.");
            //            break;
            //    }
            //}

            //Program8: Switch expression in C#
            //DisplayMeasurement(-4);  // Output: Measured value is -4; out of an acceptable range.
            //DisplayMeasurement(50);  // Output: Measured value is 50.
            //DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

            //void DisplayMeasurement(int measurement)
            //{
            //    switch (measurement)
            //    {
            //        case < 0:
            //        case > 100:        //either it should be lesstham 0 or greter than 100.
            //            Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
            //            break;

            //        default:
            //            Console.WriteLine($"Measured value is {measurement}.");
            //            break;
            //    }
            //}





            //Program9: Case Guards
            /*A case guard adds an extra condition to a case.
            The condition is written using the when keyword.
            The condition must be true (Boolean) for the case to execute.
            Both things must match:
            the pattern and the when condition*/
            //DisplayMeasurements(3, 4);  // Output: First measurement is 3, second measurement is 4.
            //DisplayMeasurements(5, 5);  // Output: Both measurements are valid and equal to 5.

            //void DisplayMeasurements(int a, int b)
            //{
            //    switch ((a, b))
            //    {
            //        case ( > 0, > 0) when a == b:
            //            Console.WriteLine($"Both measurements are valid and equal to {a}.");
            //            break;

            //        case ( > 0, > 0):
            //            Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
            //            break;

            //        default:
            //            Console.WriteLine("One or both measurements are not valid.");
            //            break;
            //    }
            //}


            //own coding 
            //PROGRAM1: IF-ELSE STATEMENT
            //int number = 27;
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    { 
            //        Console.WriteLine("Odd");
            //    }

            //PROGRAM2: IF STATEMENT 
            //int age = 28;
            //double salary = 55000;
            //bool record = false;

            //// Complex if condition
            //if (age >= 21 && salary >= 50000 && !record)
            //{
            //    Console.WriteLine("Eligible for loan");
            //}

            //PROGRAM2:IF-ELSE-IF
//            int marks = 82;

//            if (marks >= 90)
//            {
//                Console.WriteLine("Grade A+");
//            }
//            else if (marks >= 75 && marks < 90)
//            {
//                Console.WriteLine("Grade A");
//            }
//            else if (marks >= 60 && marks < 75)
//            {
//                Console.WriteLine("Grade B");
//            }
//            else if (marks >= 40 && marks < 60)
//            {
//                Console.WriteLine("Grade C");
//            }
//            else
//            {
//                Console.WriteLine("Fail");
//            }

//            //PROGRAM3: SWITCH STATEMENT 

//            int years = 6;
//            double performance = 4.5;

//            switch (years)
//            {
//                case int y when y >= 10 && performance >= 4.5:
//                    Console.WriteLine("Bonus: 30%");
//                    break;

//                case int y when y >= 5 && performance >= 4.0:
//                    Console.WriteLine("Bonus: 20%");
//                    break;

//                case int y when y >= 2 && performance >= 3.0:
//                    Console.WriteLine("Bonus: 10%");
//                    break;

//                default:
//                    Console.WriteLine("No bonus");
//                    break;
//            }


//        }
//    }
//}
